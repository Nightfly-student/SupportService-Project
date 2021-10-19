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
        //private readonly MongoDatabaseLogic _supportLogic;

        public FormAddUser()
        {
            InitializeComponent();
            _lvwColumnSorter = new ListViewColumnSorter();
            //_supportLogic = new MongoDatabaseLogic(connectedClient);
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (cbUserType.SelectedIndex <= -1) return;
            if (!MongoDatabaseLogic.Instance.Exists(txtUsername.Text))
            {
                MongoDatabaseLogic.Instance.InsertItem("Employees",
                new Person(tbFirstName.Text, tbLastName.Text, tbEmail.Text, dtpDateOfBirth.Value, int.Parse(tbPhoneNumber.Text), tbWorkLocation.Text, MongoDatabaseLogic.Instance.GetEnumValue<UserType>(cbUserType.Text), txtUsername.Text, txtPassword.Text));
            } else
            {
                MessageBox.Show("Username already exists");
            }
        }

        

        private void FormAddUser_Shown(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                MongoDatabaseLogic.Instance.ConnectToDatabase("NoDesk");
                Cursor.Current = Cursors.Default;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Something went wrong connecting to the database!\n\n" + exception.Message,
                    "Oops!", MessageBoxButtons.OK);
                Cursor.Current = Cursors.Default;
                Close();
            }
            foreach (var value in Enum.GetValues(typeof(UserType)))
            {
                cbUserType.Items.Add(MongoDatabaseLogic.Instance.GetEnumName(value));
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
        }

        private void FormAddUser_Load(object sender, EventArgs e)
        {

        }
    }
}