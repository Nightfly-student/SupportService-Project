using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SupportDAL;
using SupportModel;

namespace SupportDAO
{
    public class TicketLogic
    {
        private MongoDatabase _mongoDatabase = new MongoDatabase();
        public List<Ticket> GetTickets()
        {
            var records = _mongoDatabase.LoadFromCollection<Ticket>("Tickets");
            List<Ticket> ticketList = new List<Ticket>();
            foreach (var record in records)
            {
                ticketList.Add(new Ticket
                {
                    Id = record.Id,
                    TimeReported = record.TimeReported,
                    Subject = record.Subject,
                    IncidentType = record.IncidentType,
                    MadeBy = record.MadeBy,
                    AssignedTo = record.AssignedTo,
                    Priority = record.Priority,
                    TimeDueBy = record.TimeDueBy,
                    IncidentDescription = record.IncidentDescription
                });
            }

            return ticketList;
        }
    }
}
