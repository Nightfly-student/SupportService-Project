using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SupportDAL;
using SupportDAO;
using SupportLogic;
using SupportModel;

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

        private void button1_Click(object sender, EventArgs e)
        {
            if (UserLogic.Instance.AuthUser(tbUsername.Text, tbPassword.Text))
            {
                new FormMain().Show();
                Hide();
            } else
            {
                lblError.Text = "Wrong Login Credentials";
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
