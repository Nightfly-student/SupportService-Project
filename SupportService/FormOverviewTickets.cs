using SupportLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupportService
{
    public partial class FormOverviewTickets : Form
    {
        public FormOverviewTickets()
        {
            InitializeComponent();
        }

        private void FormOverviewTickets_Load(object sender, EventArgs e)
        {
            CheckConnection();
            GetTickets();
           
        }

        private void btnCreateIncident_Click(object sender, EventArgs e)
        {
             new FormAddTicket().Show();
        }

        private void GetTickets()
        {
            foreach (var item in MongoDatabaseLogic.Instance.TicketCollection())
            {
                lstTickets.Items.Add(item);
            }
        }


        public void CheckConnection()
        {
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
    }
}
