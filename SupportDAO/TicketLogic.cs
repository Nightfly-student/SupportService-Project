using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using SupportDAL;
using SupportModel;

namespace SupportDAO
{
    public class TicketLogic
    {
        private MongoDatabase _connectedClient;

        public TicketLogic()

        {
            ConnectClient();
        }
        public void ConnectClient()
        {
            _connectedClient = new MongoDatabase();
            _connectedClient.ConnectToDatabase("NoDesk");
        }
        public List<Ticket> GetTickets()
        {
            var records = _connectedClient.LoadFromCollection<Ticket>("Tickets");
            List<Ticket> ticketList = new List<Ticket>();
            foreach (var t in records)
            {
                ticketList.Add(t);
            }

            return ticketList;
        }
        public Person GetPerson(ObjectId id)
        {
            return _connectedClient.LoadItemById<Person>("Employees", id);
        }
    }
}
