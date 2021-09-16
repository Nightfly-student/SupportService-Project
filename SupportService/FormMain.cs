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

namespace SupportService
{
    public partial class FormMain : Form
    {
        private MongoDatabase _connectedClient;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void UpdateLabels()
        {
            if (_connectedClient == null) return;
            lblConnectionStatus.Text = "Connected to client!";
            if (_connectedClient.GetDatabaseName() != null)
            {
                lblDatabase.Text = $"Using database '{_connectedClient.GetDatabaseName()}'.";
            }
        }

        private void UpdateDatabaseDropdown()
        {
            if (_connectedClient != null)
            {
                try
                {
                    cbDatabase.Items.Clear();
                    foreach (var name in _connectedClient.DisplayDatabases())
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
                _connectedClient = new MongoDatabase();
                UpdateLabels();
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
                if (_connectedClient != null)
                {
                    try
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        _connectedClient.ConnectToDatabase(cbDatabase.Text);
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
            if (_connectedClient != null && (_connectedClient != null || _connectedClient.GetDatabaseName() != null))
            {
                try
                {
                    cbTables.Items.Clear();
                    foreach (var name in _connectedClient.DisplayTables())
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
            LoadRecords();
        }

        private void LoadRecords()
        {
            lvSelectedTable.Items.Clear();
            var records = _connectedClient.LoadAllItems<Person>(cbTables.Text);
            foreach (var record in records)
            {
                ListViewItem item = new ListViewItem(record.FirstName);
                item.SubItems.Add(record.LastName);
                item.SubItems.Add(record.Age.ToString());
                lvSelectedTable.Items.Add(item);
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            FormDashboard formDashboard = new FormDashboard();
            formDashboard.Show();
        }
    }
}
