using MongoDB.Bson;
using SupportDAO;
using SupportModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SupportService
{
    public partial class FormDashboard : Form
    {
        // Made by Tim Roffelsen
        private TicketLogic _ticketLogic;
        private Person _loggedInPerson;
        private UserLogic _userLogic;
        private List<Person> _personList;
        private List<Ticket> _ticketList;
        private List<Ticket> _orderedList;
        private string _listOrder;
        private string _searchWord;
        private bool _highFilter;
        private bool _normalFilter;
        private bool _lowFilter;
        private bool _softwareFilter;
        private bool _hardwareFilter;
        private bool _serviceFilter;
        private readonly Font _smallItemFont;
        private readonly Font _smallHeaderFont;
        private readonly Font _normalItemFont;
        private readonly Font _normalHeaderFont;

        public FormDashboard(Person person)
        {
            InitializeComponent();
            CheckConnection();
            _loggedInPerson = person;
            _listOrder = "NewOld";
            _orderedList = new List<Ticket>();
            _highFilter = false;
            _normalFilter = false;
            _lowFilter = false;
            _normalItemFont = new Font("Arial", 17, FontStyle.Regular);
            _normalHeaderFont = new Font("Arial", 17, FontStyle.Bold);
            _smallItemFont = new Font("Arial", 13, FontStyle.Regular);
            _smallHeaderFont = new Font("Arial", 13, FontStyle.Bold);
            btnEditTicket.Enabled = false;
            RefreshListView();
            OptionsClicked();
            RefreshCounts();
            if (_loggedInPerson.UserType == UserType.Employee)
            {
                btnEditTicket.Hide();
            }
        }

        private void LblExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RefreshLists()
        {
            _personList = _userLogic.GetUsers();
            _ticketList = _ticketLogic.GetTickets();
        }

        private void RefreshListView()
        {
            RefreshLists();
            OrderList();
            lvRecentTickets.Items.Clear();
            lvRecentTickets.Columns.Clear();
            FillListView();
        }

        private void FillListView()
        {
            // when _searchword is empty or when _searchword is NOT found in IncidentDescription, fill normal listview
            if (string.IsNullOrEmpty(_searchWord) || _orderedList.Find(t => t.IncidentDescription.ToLower().Contains(_searchWord.ToLower())) == null)
            {
                FillNormalListView();
            }
            // else show extended listview with IncidentDescription snippet included
            else
            {
                FillExtendedListView();
            }
        }

        private void FillNormalListView()
        {
            // make columns
            lvRecentTickets.Columns.Add("", 7);
            lvRecentTickets.Columns.Add("Subject", 240);
            lvRecentTickets.Columns.Add("Status", 150);
            lvRecentTickets.Columns.Add("Due By", 150);
            lvRecentTickets.Columns.Add("Assigned To", 204);
            lvRecentTickets.Columns.Add("Ticket Made", 174);
            foreach (var ticket in _orderedList)
            {
                // if ticket doesn't meet criteria, skip
                if (!ShowPersonResults(ticket))
                    continue;
                if (!ShowOpenTickets(ticket))
                    continue;
                if (!ShowNormalSearchResults(ticket))
                    continue;
                if (!ShowPriorityResults(ticket))
                    continue;
                if (!ShowTypeResults(ticket))
                    continue;
                // make listview item with the Tag containing the ticket for easy retrieval
                ListViewItem lvItem = new ListViewItem
                {
                    Tag = ticket,
                    Text = " ",
                    SubItems =
                    {
                        ticket.Subject,
                        ticket.Status.ToString(),
                        (ticket.TimeDueBy - DateTime.Now).TotalDays.ToString("## 'days'"),
                        GetAssignedTo(ticket.AssignedTo),
                        GetTicketTime(ticket)
                    }
                };
                // colours for first row matching the ticket's priority level
                lvItem.UseItemStyleForSubItems = false;
                ListViewColors(ticket, lvItem, _normalItemFont, _normalHeaderFont, lvRecentTickets);
                lvRecentTickets.Items.Add(lvItem);
            }
        }

        private void FillExtendedListView()
        {
            // make columns
            lvRecentTickets.Columns.Add("", 7);
            lvRecentTickets.Columns.Add("Subject", 220);
            lvRecentTickets.Columns.Add("Status", 115);
            lvRecentTickets.Columns.Add("Due By", 98);
            lvRecentTickets.Columns.Add("Assigned To", 148);
            lvRecentTickets.Columns.Add("Ticket Made", 117);
            lvRecentTickets.Columns.Add("Matching Description", 220);
            foreach (var ticket in _orderedList)
            {
                // if ticket doesn't meet criteria, skip
                if (!ShowPersonResults(ticket))
                    continue;
                if (!ShowOpenTickets(ticket))
                    continue;
                if (!ShowExtendedSearchResults(ticket))
                    continue;
                if (!ShowPriorityResults(ticket))
                    continue;
                if (!ShowTypeResults(ticket))
                    continue;
                // make listview item with the Tag containing the ticket for easy retrieval
                ListViewItem lvItem = new ListViewItem
                {
                    Tag = ticket,
                    Text = " ",
                    SubItems =
                    {
                        ticket.Subject,
                        ticket.Status.ToString(),
                        (ticket.TimeDueBy - DateTime.Now).TotalDays.ToString("## 'days'"),
                        GetAssignedTo(ticket.AssignedTo),
                        GetTicketTime(ticket),
                        GetMatchingDescription(ticket) // get matching description snippet
                    },
                    UseItemStyleForSubItems = false
                };
                ListViewColors(ticket, lvItem, _smallItemFont, _smallHeaderFont, lvRecentTickets);
                lvRecentTickets.Items.Add(lvItem);
            }
        }

        private void ListViewColors(Ticket ticket, ListViewItem lvItem, Font itemFont, Font headerFont, ListView listView)
        {
            switch (ticket.Priority)
            {
                case Priority.High:
                    lvItem.SubItems[0].BackColor = Color.Red;
                    break;

                case Priority.Normal:
                    lvItem.SubItems[0].BackColor = Color.Orange;
                    break;

                case Priority.Low:
                    lvItem.SubItems[0].BackColor = Color.Green;
                    break;
            }
            lvItem.UseItemStyleForSubItems = false;
            for (int i = 0; i < listView.Columns.Count; i++)
            {
                lvItem.SubItems[i].Font = itemFont;
                lvRecentTickets.Columns[i].ListView.Font = headerFont;
            }
        }

        private string GetMatchingDescription(Ticket ticket)
        {
            if (ticket.IncidentDescription.ToLower().Contains(_searchWord.ToLower()))
            {
                int index = ticket.IncidentDescription.IndexOf(_searchWord, StringComparison.Ordinal);
                int start = Math.Max(0, index - 15);
                int end = Math.Min(index + 15, ticket.IncidentDescription.Length - start);
                string description = $"{ticket.IncidentDescription.Substring(start, end)}";
                if (start != 0)
                    description = description.Insert(0, "...");
                if (start + end != ticket.IncidentDescription.Length)
                    description += " ...";

                return description;
            }

            return "";
        }

        private string GetTicketTime(Ticket ticket)
        {
            TimeSpan time = (DateTime.Now - ticket.TimeReported);
            if (time < new TimeSpan(1, 0, 0))
            {
                return "< 1 hour ago";
            }
            if (time < new TimeSpan(0, 23, 0, 0))
            {
                if (time.TotalHours < 2)
                {
                    return time.TotalHours.ToString("## 'hour' ago");
                }
                return time.TotalHours.ToString("## 'hours' ago");
            }
            if (time < new TimeSpan(6, 23, 0, 0))
            {
                if (time.TotalDays < 2)
                {
                    return time.TotalDays.ToString("## 'day' ago");
                }
                return time.TotalDays.ToString("## 'days' ago");
            }

            return "";
        }

        private bool ShowOpenTickets(Ticket ticket)
        {
            if (ticket.Status == Status.Closed)
                return false;
            return true;
        }

        private bool ShowPersonResults(Ticket ticket)
        {
            if (_loggedInPerson.UserType == UserType.Employee && ticket.MadeBy != _loggedInPerson.Id)
                return false;
            return true;
        }

        private bool ShowNormalSearchResults(Ticket ticket)
        {
            // if search has a keyword (not empty), and Subject DOES NOT contain the keyword, skip ticket
            if (!String.IsNullOrEmpty(_searchWord) && !ticket.Subject.ToLower().Contains(_searchWord.ToLower()))
                return false;
            return true;
        }

        private bool ShowExtendedSearchResults(Ticket ticket)
        {
            // if search has a keyword (not empty), and Subject and Description DOES NOT contain the keyword, skip ticket
            if (!String.IsNullOrEmpty(_searchWord) && !ticket.Subject.ToLower().Contains(_searchWord.ToLower()) &&
                !ticket.IncidentDescription.ToLower().Contains(_searchWord.ToLower()))
                return false;
            return true;
        }

        private bool ShowPriorityResults(Ticket ticket)
        {
            // only shows tickets with matching priority
            if (cbFilterPriority.Checked && (ticket.Priority != Priority.High || !_highFilter) &&
                (ticket.Priority != Priority.Normal || !_normalFilter) &&
                (ticket.Priority != Priority.Low || !_lowFilter))
                return false;
            return true;
        }

        private bool ShowTypeResults(Ticket ticket)
        {
            // only shows tickets with matching incident type
            if (cbFilterType.Checked && (ticket.IncidentType != TypeOfIncident.Hardware || !_hardwareFilter) &&
                (ticket.IncidentType != TypeOfIncident.Software || !_softwareFilter) &&
                (ticket.IncidentType != TypeOfIncident.Service || !_serviceFilter))
                return false;
            return true;
        }

        private void OrderList()
        {
            // sort depending on state of string _listOrder, data is retrieved from _orderedList
            DateTime timeNow;
            switch (_listOrder)
            {
                case "NewOld":
                    _orderedList = _ticketList.OrderByDescending(t => t.TimeReported).ToList();
                    break;

                case "LowHigh":
                    timeNow = DateTime.Now;
                    _orderedList = _ticketList.OrderBy(t => (t.TimeDueBy - timeNow).TotalDays).ToList();
                    break;

                case "OldNew":
                    _orderedList = _ticketList.OrderBy(t => t.TimeReported).ToList();
                    break;

                case "HighLow":
                    timeNow = DateTime.Now;
                    _orderedList = _ticketList.OrderByDescending(t => (t.TimeDueBy - timeNow).TotalDays).ToList();
                    break;
            }
        }

        private void RefreshCounts()
        {
            // total amount of tickets in listview
            lblOpenAmount.Text = lvRecentTickets.Items.Count.ToString();
            int low = 0;
            int mid = 0;
            int high = 0;
            foreach (ListViewItem listViewItem in lvRecentTickets.Items)
            {
                Ticket ticket = (Ticket)listViewItem.Tag;
                // if loggedInPerson is of type Employee, only show own tickets
                if (_loggedInPerson.UserType == UserType.Employee)
                    if (ticket.MadeBy != _loggedInPerson.Id)
                        continue;
                // ticket counts
                switch (ticket.Priority)
                {
                    case Priority.Low:
                        low++;
                        break;

                    case Priority.Normal:
                        mid++;
                        break;

                    case Priority.High:
                        high++;
                        break;
                }
            }
            lblLowAmount.Text = low.ToString();
            lblNormalAmount.Text = mid.ToString();
            lblHighAmount.Text = high.ToString();
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

        private void OptionsClicked()
        {
            foreach (Label label in pnlSortOptions.Controls)
            {
                ResetLabels(label);
            }
            switch (_listOrder)
            {
                case "NewOld":
                    ChangeLabelColor(lblRecentNO);
                    break;

                case "LowHigh":
                    ChangeLabelColor(lblDueByLH);
                    break;

                case "OldNew":
                    ChangeLabelColor(lblRecentON);
                    break;

                case "HighLow":
                    ChangeLabelColor(lblDueByHL);
                    break;
            }
        }

        private string GetAssignedTo(ObjectId id)
        {
            Person person;
            try
            {
                person = _ticketLogic.GetPerson(id);
            }
            catch
            {
                person = null;
            }

            if (person == null)
                return "-";
            return person.ToString();
        }

        private void ResetLabels(Label label)
        {
            label.ForeColor = SystemColors.ControlDarkDark;
            label.Font = new Font(label.Font.FontFamily, 12, FontStyle.Regular);
            label.Cursor = Cursors.Hand;
        }

        private void ChangeLabelColor(Label label)
        {
            label.ForeColor = Color.Black;
            label.Font = new Font(label.Font.FontFamily, 12, FontStyle.Bold);
            label.Cursor = Cursors.Default;
        }

        private void SortOptionSelected()
        {
            RefreshListView();
            OptionsClicked();
        }

        private void SortLabelClicked(string order)
        {
            if (_listOrder == order)
            {
                return;
            }
            _listOrder = order;
            SortOptionSelected();
        }

        private void LblRecentNO_Click(object sender, EventArgs e)
        {
            SortLabelClicked("NewOld");
        }

        private void LblRecentON_Click(object sender, EventArgs e)
        {
            SortLabelClicked("OldNew");
        }

        private void LblDueByLH_Click(object sender, EventArgs e)
        {
            SortLabelClicked("LowHigh");
        }

        private void LblDueByHL_Click(object sender, EventArgs e)
        {
            SortLabelClicked("HighLow");
        }

        private void TbSearchBox_TextChanged(object sender, EventArgs e)
        {
            _searchWord = tbSearchBox.Text;
            RefreshListView();
            RefreshCounts();
        }

        private bool FilterOptionSelected(bool state, Label label)
        {
            if (state)
            {
                label.ForeColor = SystemColors.ControlDarkDark;
                label.Font = new Font(label.Font.FontFamily, 12, FontStyle.Regular);
                return false;
            }
            else
            {
                label.ForeColor = Color.Black;
                label.Font = new Font(label.Font.FontFamily, 12, FontStyle.Bold);
                return true;
            }
        }

        private void LblHighP_Click(object sender, EventArgs e)
        {
            _highFilter = FilterOptionSelected(_highFilter, (Label)sender);
            if (cbFilterPriority.Checked)
            {
                RefreshListView();
            }
        }

        private void LblNormalP_Click(object sender, EventArgs e)
        {
            _normalFilter = FilterOptionSelected(_normalFilter, (Label)sender);
            if (cbFilterPriority.Checked)
            {
                RefreshListView();
            }
        }

        private void LblLowP_Click(object sender, EventArgs e)
        {
            _lowFilter = FilterOptionSelected(_lowFilter, (Label)sender);
            if (cbFilterPriority.Checked)
            {
                RefreshListView();
            }
        }

        private void CbFilterPriority_CheckedChanged(object sender, EventArgs e)
        {
            RefreshListView();
        }

        private void LblSoftware_Click(object sender, EventArgs e)
        {
            _softwareFilter = FilterOptionSelected(_softwareFilter, (Label)sender);
            if (cbFilterType.Checked)
            {
                RefreshListView();
            }
        }

        private void LblHardware_Click(object sender, EventArgs e)
        {
            _hardwareFilter = FilterOptionSelected(_hardwareFilter, (Label)sender);
            if (cbFilterType.Checked)
            {
                RefreshListView();
            }
        }

        private void LblService_Click(object sender, EventArgs e)
        {
            _serviceFilter = FilterOptionSelected(_serviceFilter, (Label)sender);
            if (cbFilterType.Checked)
            {
                RefreshListView();
            }
        }

        private void CbFilterType_CheckedChanged(object sender, EventArgs e)
        {
            RefreshListView();
        }

        private void BtnRefreshTickets_Click(object sender, EventArgs e)
        {
            RefreshLists();
            RefreshListView();
            btnEditTicket.Enabled = false;
        }

        private void BtnEditTicket_Click(object sender, EventArgs e)
        {
            Ticket ticket = (Ticket)lvRecentTickets.SelectedItems[0].Tag;
            new FormEditTicket(ticket).ShowDialog(); // add selected ticket from listview

            btnEditTicket.Enabled = false;
            RefreshLists();
            RefreshListView();
        }

        private void LvRecentTickets_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            TicketSelection();
        }

        private void TicketSelection()
        {
            btnEditTicket.Enabled = true;
        }
    }
}