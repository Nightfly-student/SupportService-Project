using SupportDAL;
using SupportLogic;
using SupportModel;
using System;
using System.Windows.Forms;

namespace SupportService
{
    public partial class FormMain : Form
    {
        private MongoDatabase _OLDWAYconnectedClient;

        public FormMain()
        {
            InitializeComponent();
            btnAddTicket.Enabled = false;
            btnAddUser.Enabled = false;
            Connect();
        }

        private void Connect()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                MongoDatabaseLogic.Instance.ConnectClient(new MongoDatabase());
                _OLDWAYconnectedClient = new MongoDatabase();
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
            if (_OLDWAYconnectedClient == null) return;
            lblConnectionStatus.Text = "Connected to client!";
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            new FormDashboard().Show();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            new UserManagement().Show();
        }

        private void btnAddTicket_Click(object sender, EventArgs e)
        {
            new FormOverviewTickets().Show();
        }
    }
}