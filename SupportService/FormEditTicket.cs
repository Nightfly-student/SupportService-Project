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
        private List<Person> _getUsers;
        private readonly TicketLogic _ticketLogic;
        private Person _loggedInPerson;

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

         

            _listoftickets.Add(_selectedTicket);
            

            foreach (var ticket in _listoftickets)
            {

                ListViewItem li = new ListViewItem();
                li.Tag = _selectedTicket;
               
                li.SubItems.Add(_selectedTicket.Subject);
                li.SubItems.Add(_selectedTicket.Status.ToString());
                li.SubItems.Add(_selectedTicket.AssignedTo.ToString());
                li.SubItems.Add(_selectedTicket.Priority.ToString());
                

                lstEditTicket.Items.Add(li);

            }

            List<Person> people = MongoDatabaseLogic.Instance.GetUsers();

            foreach (Person item in MongoDatabaseLogic.Instance.GetUsers())
            {
               
                cbAssignedToEdit.Items.Add(item);
            }


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
            Person selectedperson = (Person)cbAssignedToEdit.SelectedItem;
           // Console.WriteLine(selectedperson.Id.ToString());
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {

        }

        private void btnPriority_Click(object sender, EventArgs e)
        {

        }
    }
}
