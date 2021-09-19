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
using SupportModel;

namespace SupportService
{
    public partial class FormAddTicket : Form
    {
        //private readonly MongoDatabaseLogic _supportLogic;
        public FormAddTicket()
        {
            InitializeComponent();
          
            //_supportLogic = new MongoDatabaseLogic();
        }

        private void FormAddTicket_Load(object sender, EventArgs e)
        {
            foreach (var value in Enum.GetValues(typeof(TypeOfIncident)))
            {
                cbIncidentType.Items.Add(MongoDatabaseLogic.Instance.GetEnumName(value));
            }
            foreach (var value in Enum.GetValues(typeof(Priority)))
            {
                cbPriority.Items.Add(MongoDatabaseLogic.Instance.GetEnumName(value));
            }
        }

        private void dtpDateTimeReported_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FormAddTicket_Shown(object sender, EventArgs e)
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

     
   


        private void btn_AddTicket_Click(object sender, EventArgs e)
        {
            if (cbReportedBy.SelectedIndex <= -1) return;
            else
            {

                //MongoDatabaseLogic.Instance.InsertItem("Tickets",
                //new Ticket(dtpDateTimeReported.Value, tbSubject.Text, MongoDatabaseLogic.Instance.GetEnumName(cbIncidentType)), MongoDatabase.Parse(cbReportedBy.Text), cbPriority.Text, cbDeadline.Text, tbDescription.Text);
            }

        }


    }
}
