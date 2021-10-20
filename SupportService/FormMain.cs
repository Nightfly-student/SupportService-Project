using SupportDAL;
using SupportLogic;
using SupportModel;
using System;
using System.Windows.Forms;

namespace SupportService
{
    public partial class FormMain : Form
    {
        private MongoDatabase _connectedClient;
        private FormLogin _formLogin;
        private readonly Person _loggedInPerson;

        public FormMain(Person person, FormLogin formLogin)
        {
            InitializeComponent();
            _loggedInPerson = person;
            _formLogin = formLogin;
            btnAddTicket.Enabled = false;
            btnAddUser.Enabled = false;
            if (_loggedInPerson.UserType == UserType.Employee)
                btnAddUser.Hide();
            Connect();
        }

        private void Connect()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                MongoDatabaseLogic.Instance.ConnectClient(new MongoDatabase());
                _connectedClient = new MongoDatabase();
                UpdateLabels();
                btnAddTicket.Enabled = true;
                btnAddUser.Enabled = true;
                Cursor.Current = Cursors.Default;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Something went wrong connecting to the client!\n\n" + exception.Message, "Oops!",
                    MessageBoxButtons.OK);
            }
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void UpdateLabels()
        {
            if (_connectedClient == null) return;
            lblConnectionStatus.Text = "Connected to client!";
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            new FormDashboard(_loggedInPerson).ShowDialog();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            new UserManagement().ShowDialog();
        }

        private void btnAddTicket_Click(object sender, EventArgs e)
        {
            new FormAddTicket(_loggedInPerson).ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Hide();
            _formLogin.Show();
        }
    }
}