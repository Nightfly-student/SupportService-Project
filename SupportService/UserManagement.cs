using SupportLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SupportDAO;
using System.Windows.Forms;

namespace SupportService
{
    public partial class UserManagement : Form
    {
        private readonly ListViewColumnSorter _lvwColumnSorter;

        public UserManagement()
        {
            InitializeComponent();
            _lvwColumnSorter = new ListViewColumnSorter();
            lstUsers.ListViewItemSorter = _lvwColumnSorter;
        }
        private void UserManagement_Load(object sender, EventArgs e)
        {
            checkConn();
            ColumNames();
            LoadItems();
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            new FormAddUser().Show();
        }
        public void LoadItems()
        {
            foreach (var item in UserLogic.Instance.UserCollection())
            {
                lstUsers.Items.Add(item);
            }
            
            foreach (ColumnHeader ch in lstUsers.Columns)
            {
                ch.Width = -2;
            }
        }
        private void ColumNames()
        {
            lstUsers.GridLines = true;
        }
        public void checkConn()
        {
            try
            {
                UserLogic.Instance.ConnectToDatabase("NoDesk");
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
        private void lstUsers_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == _lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (_lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    _lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    _lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                _lvwColumnSorter.SortColumn = e.Column;
                _lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            lstUsers.Sort();
        }

        private void txtFilterUsers_TextChanged(object sender, EventArgs e)
        {
            SearchFunctionality searchFunctionality = new SearchFunctionality();

            if (!searchFunctionality.Search(txtFilterUsers, lstUsers))
            {
                LoadItems();
            }
          //  Search(txtFilterUsers, lstUsers);
        }
        //Search based on text and list
        public void Search(TextBox text, ListView list)
        {
            if (text.Text != "")
            {
                foreach (ListViewItem item in list.Items)
                {
                    if (item.SubItems[1].Text.ToLower().Contains(text.Text.ToLower()))
                    {
                        item.Selected = true;
                    }
                    else
                    {
                        list.Items.Remove(item);
                    }
                    if (list.SelectedItems.Count == 1)
                    {
                        list.Focus();
                    }
                }
            }
            else
            {
                list.Items.Clear();
                LoadItems();
            }
        }
    }
}
