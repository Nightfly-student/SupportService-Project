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
using SupportLogic;
using SupportDAO;


namespace SupportService
{
    public partial class FormEditTicket : Form
    {
        Ticket _selectedTicket;
        private List<Ticket> _listoftickets;
        private TicketLogic _ticketlogics;
        private readonly TicketLogic _ticketLogic;
        private TransferTicket _transferticket;
        

        public FormEditTicket(Ticket ticket)
        {
            InitializeComponent();
            _selectedTicket = ticket;
            _ticketlogics = new TicketLogic();
            _listoftickets = new List<Ticket>();
            _ticketLogic = new TicketLogic();
            _transferticket = new TransferTicket();
            btnStatus.Hide();
            btnAssignedTo.Hide();
            btnPriority.Hide();
            checkConnection();
        }


        private void FormEditTicket_Load(object sender, EventArgs e)
        {
            FillComboBoxItem();
            FillListViewItem();
        }

        

        public void FillComboBoxItem()
        {
            // Fills the combobox with the data from the database

            foreach (var value in Enum.GetValues(typeof(Priority)))
            {
                cbPriorityEdit.Items.Add(MongoDatabaseLogic.Instance.GetEnumName(value));
            }

            foreach (var value in Enum.GetValues(typeof(Status)))
            {
                cbStatusEdit.Items.Add(MongoDatabaseLogic.Instance.GetEnumName(value));
            }

            foreach (Person item in MongoDatabaseLogic.Instance.GetUsers())
            {
                cbAssignedToEdit.Items.Add(item);
            }
        }

        public void FillListViewItem()
        {
            // Fills the string variable with the firstname + lastname if the objectID is not equal to the default value of MongoDB

            string assignedPersonString = _ticketLogic.isAssignedToValid(_selectedTicket.AssignedTo) ? _ticketLogic.GetPerson(_selectedTicket.AssignedTo).ToString() : "";

            // Fills listview with the selectedticket from the listview in formDashboard

            ListViewItem li = new ListViewItem();
            li.Tag = _selectedTicket;
            li.Text = _selectedTicket.Subject;
            li.SubItems.Add(_selectedTicket.Status.ToString());
            li.SubItems.Add(assignedPersonString);
            li.SubItems.Add(_selectedTicket.Priority.ToString());

            lstEditTicket.Items.Add(li);
        }

        public void checkConnection()
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
        }

        

        private void btnAssignedTo_Click(object sender, EventArgs e)
        {
            try
            {
                Person selectedperson = (Person)cbAssignedToEdit.SelectedItem;

                _transferticket.UpdateAssignedTo(selectedperson, _selectedTicket);
               
                CheckIfAssignedTo();
                MessageBox.Show($"Assigned To edited!");
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Something failed\n{exception.Message}\nAssigned to has not been edited");
            }

            RefreshItems();
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            try
            {
                Status selectedStatus = (Status)System.Enum.Parse(typeof(Status), cbStatusEdit.SelectedItem.ToString());

                _transferticket.UpdateStatus(selectedStatus, _selectedTicket);

                MessageBox.Show($"Status edited!");
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Something failed\n{exception.Message}\nStatus has not been edited");
            }

            RefreshItems();
        }

        private void btnPriority_Click(object sender, EventArgs e)
        {
            try 
            {
                Priority selectedPriority = (Priority)System.Enum.Parse(typeof(Priority), cbPriorityEdit.SelectedItem.ToString());

                _transferticket.UpdatePriority(selectedPriority, _selectedTicket);

                MessageBox.Show($"Priority edited!");
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Something failed\n{exception.Message}\nPriority has not been edited");
            }

            RefreshItems();
        }

        private void btnRefreshEditTicket_Click(object sender, EventArgs e)
        {
            RefreshItems();
            MessageBox.Show($"Refreshed succesfully!");
        }

        private void RefreshItems()
        {
            // Refreshes the items from the listview and combobox and hides the buttons again

            ClearListView();
            ClearComboBox();
            FillListViewItem();
            FillComboBoxItem();

            btnStatus.Hide();
            btnPriority.Hide();
            btnAssignedTo.Hide();
            
        }

        public void ClearListView()
        {
            lstEditTicket.Items.Clear();
        }

        public void ClearComboBox()
        {
            cbAssignedToEdit.SelectedIndex = -1;
            cbPriorityEdit.SelectedIndex = -1;
            cbStatusEdit.SelectedIndex = -1;

            cbAssignedToEdit.Items.Clear();
            cbPriorityEdit.Items.Clear();
            cbStatusEdit.Items.Clear();

          
        }

        public void CheckIfAssignedTo()
        {
            // Automatically makes the Status go from unassigned to assigned when a ticket gets assigned to a person

            if(_selectedTicket.Status == SupportModel.Status.Unassigned)
            {
                Status selectedStatus = SupportModel.Status.Assigned;

                Ticket oldticket = _selectedTicket;
                Ticket newticket = oldticket;
                newticket.Status = selectedStatus;

                _ticketLogic.updateTicket(oldticket, newticket);

            }
        }

        public void CheckIfStatusSelected()
        {
            if(cbStatusEdit.SelectedIndex >= 0)
            {
                btnStatus.Show();
            }

        }

        public void CheckIfPrioritySelected()
        {
            if (cbPriorityEdit.SelectedIndex >= 0)
            {
                btnPriority.Show();
            }
        }

        public void CheckIfAssignedToSelected()
        {
            if (cbAssignedToEdit.SelectedIndex >= 0)
            {
                btnAssignedTo.Show();
            }
        }

        private void cbStatusEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckIfStatusSelected();
            
        }

        private void cbAssignedToEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckIfAssignedToSelected();
        }

        private void cbPriorityEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckIfPrioritySelected();
        }
    }
}
