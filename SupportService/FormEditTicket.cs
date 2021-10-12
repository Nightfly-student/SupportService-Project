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

namespace SupportService
{
    public partial class FormEditTicket : Form
    {
        Ticket _selectedTicket;
        public FormEditTicket(Ticket ticket)
        {
            InitializeComponent();
            _selectedTicket = ticket;
        }
    }
}
