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
            lstUsers.FullRowSelect = true;
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
            this.Close();
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
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            lstUsers.Items.Clear();
            LoadItems();
        }
        public void Reload()
        {
            lstUsers.Items.Clear();
            LoadItems();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(lstUsers.SelectedItems.Count != 0)
            {
                UserLogic.Instance.deleteUser(lstUsers.SelectedItems[0].SubItems[1].Text);
                MessageBox.Show("Deleted " + lstUsers.SelectedItems[0].SubItems[1].Text);
                lstUsers.Items.Clear();
                LoadItems();
            } else
            {
                MessageBox.Show("Select an user first");
            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (lstUsers.SelectedItems.Count != 0)
            {

            } else
            {
                MessageBox.Show("Select an user first");
            }
        }
    }
}
