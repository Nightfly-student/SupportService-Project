using SupportDAL;
using SupportModel;
using System;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;

namespace SupportService
{
    public partial class FormAddUser : Form
    {
        private readonly MongoDatabase _connectedClient;

        public FormAddUser(MongoDatabase connectedClient)
        {
            InitializeComponent();
            _connectedClient = connectedClient;
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
            _connectedClient.InsertItem(typeOfUser.ToString(),
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
                _connectedClient.ConnectToDatabase("Employees");
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
            var records = _connectedClient.LoadFromCollection<Person>(collectionName);
            foreach (var record in records)
            {
                ListViewItem item = new ListViewItem(record.FirstName);
                item.SubItems.Add(record.LastName);
                item.SubItems.Add(collectionName);
                item.SubItems.Add(record.Email);
                item.SubItems.Add(record.DateOfBirth.ToString("dd/MM/yyyy"));
                item.SubItems.Add(record.PhoneNumber.ToString());
                item.SubItems.Add(record.WorkLocation);
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
            foreach (var name in _connectedClient.DisplayCollections())
            {
                LoadItems(name);
            }
        }
    }
}