using SupportModel;
using SupportLogic;
using System;
using System.Windows.Forms;

namespace SupportService
{
    public partial class FormAddUser : Form
    {
        private readonly ListViewColumnSorter _lvwColumnSorter;

        public FormAddUser()
        {
            InitializeComponent();
            _lvwColumnSorter = new ListViewColumnSorter();
            cbUserType.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {

            if (tbFirstName.Text != "" || tbLastName.Text != "" || tbEmail.Text != "" || tbWorkLocation.Text != "" || tbPhoneNumber.Text != "")
            {
                if (cbUserType.SelectedIndex <= -1)
                {
                    MessageBox.Show("Select User Type");
                    return;
                }
                if (!MongoDatabaseLogic.Instance.Exists(txtUsername.Text) && txtUsername.Text.Length > 3)
                {
                    if (tbPhoneNumber.Text.Length <= 12)
                    {
                        if (tbEmail.Text.Contains("@"))
                        {
                            MongoDatabaseLogic.Instance.InsertItem("Employees",
                            new Person(tbFirstName.Text, tbLastName.Text, tbEmail.Text, int.Parse(tbPhoneNumber.Text), tbWorkLocation.Text, MongoDatabaseLogic.Instance.GetEnumValue<UserType>(cbUserType.Text), txtUsername.Text, txtPassword.Text));
                            new UserManagement().Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Email is not valid");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Phonenumber is too long");
                    }
                }
                else
                {
                    MessageBox.Show("Username already exists");
                }
            }
            else
            {
                MessageBox.Show("Please fill in all Textfields");
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
            cbUserType.SelectedIndex = 1;
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
        private void button1_Click(object sender, EventArgs e)
        {
            new UserManagement().Show();
            this.Close();
        }
    }
}