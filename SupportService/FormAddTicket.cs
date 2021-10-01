using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
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
            

            FormAddTicket_Shown(sender, e);

            foreach (var value in Enum.GetValues(typeof(TypeOfIncident)))
            {
                cbIncidentType.Items.Add(MongoDatabaseLogic.Instance.GetEnumName(value));
            }
            foreach (var value in Enum.GetValues(typeof(Priority)))
            {
                cbPriority.Items.Add(MongoDatabaseLogic.Instance.GetEnumName(value));
            }

            foreach (var item in MongoDatabaseLogic.Instance.GetUserName())
            {
                cbReportedBy.Items.Add(item);
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
            if (!MongoDatabaseLogic.Instance.Exists(cbReportedBy.Text))
            {
                int days = 0;
                switch (cbDeadline.Text)
                {
                    case "7 days":
                        days = 7;
                        break;
                    case "14 days":
                        days = 14;
                        break;
                    case "28 days":
                        days = 28;
                        break;
                    case "6 months":
                        days = 182;
                        break;
                        
                    default:
                        break;
                }
                DateTime deadline = dtpDateTimeReported.Value.AddDays(days);
                MongoDatabaseLogic.Instance.InsertItem("Tickets",
                new Ticket(dtpDateTimeReported.Value, tbSubject.Text, MongoDatabaseLogic.Instance.GetEnumValue<TypeOfIncident>(cbIncidentType.Text.ToString()), cbReportedBy.Text, MongoDatabaseLogic.Instance.GetEnumValue<Priority>(cbPriority.Text.ToString()), deadline, tbDescription.Text));
            }
            else
            {
                MessageBox.Show("Username already exists");
            }

        }


    }
}
