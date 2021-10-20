using SupportDAO;
using System;
using System.Windows.Forms;
using SupportModel;

namespace SupportService
{
    public partial class FormLogin : Form
    {
        //Jelle Toonen | Design door Tim Roffelsen//
        public FormLogin()
        {
            InitializeComponent();
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                UserLogic.Instance.Connect();
                Cursor.Current = Cursors.Default;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Something went wrong connecting to the client!\n\n" + exception.Message, "Oops!",
                    MessageBoxButtons.OK);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Person person = UserLogic.Instance.AuthUser(tbUsername.Text, tbPassword.Text);
            if (person != null)
            {
                new FormMain(person, this).Show();
                tbPassword.Clear();
                lblError.Enabled = false;
                Hide();
            }
            else
            {
                lblError.Text = "Wrong Login Credentials";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnLogin_Click(this, new EventArgs());
            }
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnLogin_Click(this, new EventArgs());
            }
        }
    }
}