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
using SupportLogic;
using SupportModel;

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
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void UpdateLabels()
        {
            if (_OLDWAYconnectedClient == null) return;
            lblConnectionStatus.Text = "Connected to client!";
            if (_OLDWAYconnectedClient.GetDatabaseName() != null)
            {
                lblDatabase.Text = $"Using database '{_OLDWAYconnectedClient.GetDatabaseName()}'.";
            }
        }

        private void UpdateDatabaseDropdown()
        {
            if (_OLDWAYconnectedClient != null)
            {
                try
                {
                    cbDatabase.Items.Clear();
                    foreach (var name in _OLDWAYconnectedClient.DisplayDatabases())
                    {
                        cbDatabase.Items.Add(name);
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Something went wrong connecting to the database!\n\n" + exception.Message, "Oops",
                        MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Please connect to client first!", "Oops!", MessageBoxButtons.OK);
            }
        }

        private void btnConnectToClient_Click(object sender, EventArgs e)
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

        private void btnConnectToDatabase_Click(object sender, EventArgs e)
        {
            if (cbDatabase.SelectedIndex > -1)
            {
                if (_OLDWAYconnectedClient != null)
                {
                    try
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        _OLDWAYconnectedClient.ConnectToDatabase(cbDatabase.Text);
                        UpdateLabels();
                        Cursor.Current = Cursors.Default;
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Something went wrong connecting to the database!\n\n" + exception.Message,
                            "Oops!", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Please connect to client first!", "Oops!", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Please select a database to connect to!", "Oops!", MessageBoxButtons.OK);
            }
        }

        private void cbDatabase_DropDown(object sender, EventArgs e)
        {
            UpdateDatabaseDropdown();
        }

        private void cbTables_DropDown(object sender, EventArgs e)
        {
            if (_OLDWAYconnectedClient != null && (_OLDWAYconnectedClient != null || _OLDWAYconnectedClient.GetDatabaseName() != null))
            {
                try
                {
                    cbTables.Items.Clear();
                    foreach (var name in _OLDWAYconnectedClient.DisplayCollections())
                    {
                        cbTables.Items.Add(name);
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Something went wrong!\n\n" + exception.Message, "Oops",
                        MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Please connect to client/database first!", "Oops", MessageBoxButtons.OK);
            }
        }

        private void cbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadItems();
        }

        private void LoadItems()
        {
            lvSelectedTable.Items.Clear();
            var records = _OLDWAYconnectedClient.LoadFromCollection<Person>(cbTables.Text);
            foreach (var record in records)
            {
                ListViewItem item = new ListViewItem(record.FirstName);
                item.SubItems.Add(record.LastName);
                item.SubItems.Add(record.DateOfBirth.ToString("dd/MM/yyyy"));
                lvSelectedTable.Items.Add(item);
            }
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
                new FormAddTicket().Show();
        }
    }
}
