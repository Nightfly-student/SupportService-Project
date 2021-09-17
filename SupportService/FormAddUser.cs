using SupportDAL;
using SupportModel;
using SupportLogic;
using System;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;

namespace SupportService
{
    public partial class FormAddUser : Form
    {
        private readonly ListViewColumnSorter _lvwColumnSorter;
        private readonly MongoDatabaseLogic _supportLogic;

        public FormAddUser(MongoDatabase connectedClient)
        {
            InitializeComponent();
            _lvwColumnSorter = new ListViewColumnSorter();
            _supportLogic = new MongoDatabaseLogic(connectedClient);
            lvEmployees.ListViewItemSorter = _lvwColumnSorter;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (cbUserType.SelectedIndex <= -1) return;
            var typeOfUser = cbUserType.Text switch
            {
                "Employee" => TypeOfUser.Employee,
                "Service desk employee" => TypeOfUser.ServiceDeskEmployee,
                _ => TypeOfUser.Employee
            };
            _supportLogic.InsertItem(typeOfUser.ToString(),
                new Person(tbFirstName.Text, tbLastName.Text, tbEmail.Text, dtpDateOfBirth.Value, int.Parse(tbPhoneNumber.Text), tbWorkLocation.Text));
        }

        private string GetEnumName<T>(T value)
        {
            Type type = value.GetType();
            string name = Enum.GetName(type, value);
            if (name == null) return value.ToString();
            FieldInfo fieldInfo = type.GetField(name);
            if (fieldInfo == null) return value.ToString();
            if (Attribute.GetCustomAttribute(fieldInfo,
                typeof(DescriptionAttribute)) is DescriptionAttribute attr)
            {
                return attr.Description;
            }
            return value.ToString();
        }

        private void FormAddUser_Shown(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                _supportLogic.ConnectToDatabase("Employees");
                Cursor.Current = Cursors.Default;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Something went wrong connecting to the database!\n\n" + exception.Message,
                    "Oops!", MessageBoxButtons.OK);
                Cursor.Current = Cursors.Default;
                Close();
            }
            foreach (var value in Enum.GetValues(typeof(TypeOfUser)))
            {
                cbUserType.Items.Add(GetEnumName(value));
            }
            foreach (ColumnHeader ch in lvEmployees.Columns)
            {
                ch.Width = -2;
            }
        }
        private void LoadItems(string collectionName)
        {
            foreach (var item in _supportLogic.LoadFromCollection(collectionName))
            {
                lvEmployees.Items.Add(item);
            }

            foreach (ColumnHeader ch in lvEmployees.Columns)
            {
                ch.Width = -2;
            }
        }
        private void btnRefreshList_Click(object sender, EventArgs e)
        {
            lvEmployees.Items.Clear();
            foreach (var name in _supportLogic.DisplayCollections())
            {
                LoadItems(name);
            }
        }

        private void lvEmployees_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == _lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (_lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    _lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    _lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                _lvwColumnSorter.SortColumn = e.Column;
                _lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            lvEmployees.Sort();
        }
    }
}