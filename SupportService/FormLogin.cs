using SupportDAO;
using System;
using System.Windows.Forms;

namespace SupportService
{
    public partial class FormLogin : Form
    {
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
            if (UserLogic.Instance.AuthUser(tbUsername.Text, tbPassword.Text))
            {
                new FormMain().Show();
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