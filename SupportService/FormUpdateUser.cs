using SupportLogic;
using SupportDAO;
using SupportModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupportService
{
    public partial class FormUpdateUser : Form
    {
        Person person, newPerson;
        public FormUpdateUser(Person p)
        {
            InitializeComponent();
            tbFirstName.Text = p.FirstName;
            tbLastName.Text = p.LastName;
            tbPhoneNumber.Text = p.PhoneNumber.ToString();
            tbEmail.Text = p.Email;
            tbWorkLocation.Text = p.WorkLocation;
            person = p;
            lblSetUsername.Text += p.Username;
            cbUserType.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (tbFirstName.Text != "" || tbLastName.Text != "" || tbEmail.Text != "" || tbWorkLocation.Text != "" || tbPhoneNumber.Text != "")
            {
                if (cbUserType.SelectedIndex <= -1)
                {
                    MessageBox.Show("Select User Type");
                    return;
                }
                    if (tbPhoneNumber.Text.Length <= 12)
                    {
                        if (tbEmail.Text.Contains("@"))
                        {
                        newPerson = new Person(tbFirstName.Text, tbLastName.Text, tbEmail.Text, int.Parse(tbPhoneNumber.Text), tbWorkLocation.Text, MongoDatabaseLogic.Instance.GetEnumValue<UserType>(cbUserType.Text), person.Username, person.Password);
                        newPerson.Id = person.Id;
                        UserLogic.Instance.updateUser(person, newPerson);
                        MessageBox.Show("User has been updated");
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
                MessageBox.Show("Please fill in all Textfields");
            }
        }

        private void FormUpdateUser_Load(object sender, EventArgs e)
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
            var counter = 0;
            foreach (var value in Enum.GetValues(typeof(UserType)))
            {
                cbUserType.Items.Add(MongoDatabaseLogic.Instance.GetEnumName(value));
                if(value.ToString() == person.UserType.ToString()) {
                    cbUserType.SelectedIndex = counter;
                }
                counter++;
            }
        }

        private void btnCredentials_Click(object sender, EventArgs e)
        {
            if(tbOldPassword.Text != "" || tbConfirmPassword.Text != "")
            {
                Person p = UserLogic.Instance.AuthUser(lblSetUsername.Text, tbOldPassword.Text);

                if(p != null)
                {
                    Person newP = p;
                    newP.Password = tbConfirmPassword.Text;
                    UserLogic.Instance.updateCredentials(p.Id, newP);
                    MessageBox.Show("Updated Credentials");
                } else
                {
                    MessageBox.Show("Invalid Credentials");
                }
            } else
            {
                MessageBox.Show("Please fill in old password and new password");
            }


        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            new UserManagement().Show();
            this.Close();
        }
    }
}
