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
        

        public FormEditTicket(Ticket ticket)
        {
            InitializeComponent();
            _selectedTicket = ticket;
            _ticketlogics = new TicketLogic();
            _listoftickets = new List<Ticket>();
            _ticketLogic = new TicketLogic();
            checkConnection();
        }


        private void FormEditTicket_Load(object sender, EventArgs e)
        {

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

            FillListViewItem();
        }

        public void FillListViewItem()
        {
            string assignedPersonString = _ticketLogic.isAssignedToValid(_selectedTicket.AssignedTo) ? _ticketLogic.GetPerson(_selectedTicket.AssignedTo).ToString() : "";

            ListViewItem li = new ListViewItem();
            li.Tag = _selectedTicket;
            li.Text = _selectedTicket.Subject;
            li.SubItems.Add(_selectedTicket.Status.ToString());
            li.SubItems.Add(assignedPersonString);
            li.SubItems.Add(_selectedTicket.Priority.ToString());

            lstEditTicket.Items.Add(li);
        }

        public void ClearListView()
        {
            lstEditTicket.Items.Clear();
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

                Ticket oldticket = _selectedTicket;
                Ticket newticket = oldticket;
                newticket.AssignedTo = selectedperson.Id;

                _ticketLogic.updateTicket(oldticket, newticket);

                MessageBox.Show($"Assigned To edited!");
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Something failed\n{exception.Message}\nAssigned to has not been edited");
            }

            RefreshLists();
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            try
            {
                Status selectedStatus = (Status)System.Enum.Parse(typeof(Status), cbStatusEdit.SelectedItem.ToString());

                Ticket oldticket = _selectedTicket;
                Ticket newticket = oldticket;
                newticket.Status = selectedStatus;

                _ticketLogic.updateTicket(oldticket, newticket);

                MessageBox.Show($"Status edited!");
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Something failed\n{exception.Message}\nStatus has not been edited");
            }

            RefreshLists();
        }

        private void btnPriority_Click(object sender, EventArgs e)
        {
            try {
                Priority selectedPriority = (Priority)System.Enum.Parse(typeof(Priority), cbPriorityEdit.SelectedItem.ToString());


                Ticket oldticket = _selectedTicket;
                Ticket newticket = oldticket;
                newticket.Priority = selectedPriority;

                _ticketLogic.updateTicket(oldticket, newticket);

                MessageBox.Show($"Priority edited!");
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Something failed\n{exception.Message}\nPriority has not been edited");
            }

            RefreshLists();
        }

        private void btnRefreshEditTicket_Click(object sender, EventArgs e)
        {
            RefreshLists();
            MessageBox.Show($"Refreshed succesfully!");
        }

        private void RefreshLists()
        {
            ClearListView();
            FillListViewItem();
        }
    }
}
