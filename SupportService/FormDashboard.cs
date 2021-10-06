using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SupportDAO;
using SupportLogic;
using SupportModel;

namespace SupportService
{
    public partial class FormDashboard : Form
    {
        private TicketLogic _ticketLogic;
        private UserLogic _userLogic;
        private List<Person> _personList;
        private List<Ticket> _ticketList;

        public FormDashboard()
        {
            InitializeComponent();
            CheckConnection();
            RefreshLists();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            RefreshCounts();
        }

        private void RefreshLists()
        {
            _personList = _userLogic.GetUsers();
            _ticketList = _ticketLogic.GetTickets();
            foreach (var ticket in _ticketList.OrderByDescending(x => x.TimeReported))
            {
                
                lvRecentTickets.Items.Add(new ListViewItem
                {

                    Text = ticket.Subject,
                    SubItems =
                    {
                        ticket.MadeBy.ToString(),
                        ticket.TimeReported.ToString("g"),
                        ticket.Status.ToString(),
                        (ticket.TimeDueBy - DateTime.Now).TotalDays.ToString("## 'days'")
                    }
                });
            }
        }

        private void RefreshCounts()
        {
            lblTotalAmount.Text = _ticketList.Count.ToString();
            lblLowAmount.Text = _ticketList.Count(i => i.Priority == Priority.Low).ToString();
            lblNormalAmount.Text = _ticketList.Count(i => i.Priority == Priority.Normal).ToString();
            lblHighAmount.Text = _ticketList.Count(i => i.Priority == Priority.High).ToString();
        }
        public void CheckConnection()
        {
            try
            {
                _userLogic = UserLogic.Instance;
                _ticketLogic = new TicketLogic();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Something went wrong connecting to the database!\n\n" + exception.Message,
                    "Oops!", MessageBoxButtons.OK);
                Close();
            }
        }
    }
}
