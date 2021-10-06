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
    public partial class SupportUIDashboard1 : Form
    {
        // sort by priority/type
        // other search? (radiobutton/label/   AND/OR
        private TicketLogic _ticketLogic;

        private UserLogic _userLogic;
        private List<Person> _personList;
        private List<Ticket> _ticketList;
        private List<Ticket> _orderedList;
        private string _listOrder;
        private string _searchWord;
        private readonly Font _smallItemFont;
        private readonly Font _smallHeaderFont;
        private readonly Font _normalItemFont;
        private readonly Font _normalHeaderFont;

        public SupportUIDashboard1()
        {
            InitializeComponent();
            CheckConnection();
            _listOrder = "NewOld";
            _orderedList = new List<Ticket>();
            _normalItemFont = new Font("Arial", 17, FontStyle.Regular);
            _normalHeaderFont = new Font("Arial", 17, FontStyle.Bold);
            _smallItemFont = new Font("Arial", 13, FontStyle.Regular);
            _smallHeaderFont = new Font("Arial", 13, FontStyle.Bold);
            RefreshListView();
            OptionsClicked();
            RefreshCounts();
        }

        private void lblExit_Click(object sender, EventArgs e)
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
            if (string.IsNullOrEmpty(_searchWord) || _orderedList.Find(t => t.IncidentDescription.ToLower().Contains(_searchWord.ToLower())) == null)
            {
                FillNormalListView();
            }
            else
            {
                FillExtendedListView();
            }
        }

        private void FillNormalListView()
        {
            lvRecentTickets.Columns.Add("", 7);
            lvRecentTickets.Columns.Add("Subject", 240);
            lvRecentTickets.Columns.Add("Status", 150);
            lvRecentTickets.Columns.Add("Due By", 150);
            lvRecentTickets.Columns.Add("Assigned To", 204);
            lvRecentTickets.Columns.Add("Ticket Made", 174);
            foreach (var ticket in _orderedList)
            {
                if (!String.IsNullOrEmpty(_searchWord) && !ticket.Subject.ToLower().Contains(_searchWord.ToLower()) &&
                    !ticket.IncidentDescription.ToLower().Contains(_searchWord.ToLower()) &&
                    !ticket.MadeBy.ToString().ToLower().Contains(_searchWord.ToLower()) && (ticket.AssignedTo == null ||
                        !ticket.AssignedTo.ToString().ToLower().Contains(_searchWord.ToLower()))) continue;
                ListViewItem lvItem = new ListViewItem
                {
                    Tag = ticket,
                    Text = " ",
                    SubItems =
                    {
                        ticket.Subject,
                        ticket.Status.ToString(),
                        (ticket.TimeDueBy - DateTime.Now).TotalDays.ToString("## 'days'"),
                        ticket.AssignedTo == null ? "-" : ticket.AssignedTo.ToString(),
                        GetTicketTime(ticket)
                    }
                };
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
                ListViewDesign(ticket, lvItem, _normalItemFont, _normalHeaderFont, lvRecentTickets);
                lvRecentTickets.Items.Add(lvItem);
            }
        }

        private void FillExtendedListView()
        {
            lvRecentTickets.Columns.Add("", 7);
            lvRecentTickets.Columns.Add("Subject", 220);
            lvRecentTickets.Columns.Add("Status", 115);
            lvRecentTickets.Columns.Add("Due By", 98);
            lvRecentTickets.Columns.Add("Assigned To", 155);
            lvRecentTickets.Columns.Add("Ticket Made", 117);
            lvRecentTickets.Columns.Add("Search Description", 220);
            foreach (var ticket in _orderedList)
            {
                if (!ticket.IncidentDescription.ToLower().Contains(_searchWord.ToLower())) continue;
                ListViewItem lvItem = new ListViewItem
                {
                    Tag = ticket,
                    Text = " ",
                    SubItems =
                    {
                        ticket.Subject,
                        ticket.Status.ToString(),
                        (ticket.TimeDueBy - DateTime.Now).TotalDays.ToString("## 'days'"),
                        ticket.AssignedTo == null ? "-" : ticket.AssignedTo.ToString(),
                        GetTicketTime(ticket),
                        GetMatchingDescription(ticket)
                    }
                };
                lvItem.UseItemStyleForSubItems = false;
                ListViewDesign(ticket, lvItem, _smallItemFont, _smallHeaderFont, lvRecentTickets);
                lvRecentTickets.Items.Add(lvItem);
            }
        }

        private void ListViewDesign(Ticket ticket, ListViewItem lvItem, Font itemFont, Font headerFont, ListView listView)
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
            int index = ticket.IncidentDescription.IndexOf(_searchWord, StringComparison.Ordinal);
            int start = Math.Max(0, index - 15);
            int end = Math.Min(index + 15, ticket.IncidentDescription.Length - start);
            string description = $"{ticket.IncidentDescription.Substring(start, end)}";
            if (start != 0)
                description = description.Insert(0, "...");
            if (start + end != ticket.IncidentDescription.Length)
                description += "<b> ...";

            return description;
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

        private void OrderList()
        {
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
            lblOpenAmount.Text = _ticketList.Count.ToString();
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

        private void OptionsClicked()
        {
            foreach (Label label in pnlSortOptions.Controls)
            {
                label.ForeColor = SystemColors.ControlDarkDark;
                label.Font = new Font(label.Font.FontFamily, 12, FontStyle.Regular);
                label.Cursor = Cursors.Hand;
            }
            switch (_listOrder)
            {
                case "NewOld":
                    ChangeOptionsColor(lblRecentNO);
                    break;

                case "LowHigh":
                    ChangeOptionsColor(lblDueByLH);
                    break;

                case "OldNew":
                    ChangeOptionsColor(lblRecentON);
                    break;

                case "HighLow":
                    ChangeOptionsColor(lblDueByHL);
                    break;
            }
        }

        private void ChangeOptionsColor(Label label)
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

        private void LabelClicked(string order)
        {
            if (_listOrder == order)
            {
                return;
            }
            _listOrder = order;
            SortOptionSelected();
        }

        private void lblRecentNO_Click(object sender, EventArgs e)
        {
            LabelClicked("NewOld");
        }

        private void lblRecentON_Click(object sender, EventArgs e)
        {
            LabelClicked("OldNew");
        }

        private void lblDueByLH_Click(object sender, EventArgs e)
        {
            LabelClicked("LowHigh");
        }

        private void lblDueByHL_Click(object sender, EventArgs e)
        {
            LabelClicked("HighLow");
        }

        private void tbSearchBox_TextChanged(object sender, EventArgs e)
        {
            _searchWord = tbSearchBox.Text;
            RefreshListView();
        }
    }
}