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
    }
}
