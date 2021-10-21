using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SupportModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using SupportLogic;
using SupportDAO;
namespace SupportService
{
    class TransferTicket
    {
        TicketLogic ticket = new TicketLogic();

        // Made by Fejsal Aziz
        
        public void UpdateAssignedTo(Person selectedperson, Ticket selectedTicket )
        {
           
            Ticket newticket = selectedTicket;
            newticket.AssignedTo = selectedperson.Id;

            ticket.updateTicket(selectedTicket, newticket);
          
        }

        public void UpdatePriority(Priority selectedPriority, Ticket selectedTicket)
        {

            Ticket newticket = selectedTicket;
            newticket.Priority = selectedPriority;

            ticket.updateTicket(selectedTicket, newticket);

        }

        public void UpdateStatus(Status selectedStatus, Ticket selectedTicket)
        {
          
            Ticket newticket = selectedTicket;
            newticket.Status = selectedStatus;

            ticket.updateTicket(selectedTicket, newticket);

        }

    }
}
