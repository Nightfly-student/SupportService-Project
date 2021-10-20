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

        public void updateTicket(Ticket oldT, Ticket newT)
        {
            _connectedClient.UpdateItemByObjectID("Tickets", oldT.Id, "_id", newT);
        }

        public bool isAssignedToValid(ObjectId id)
        {
            // returns if a Id is not assigned yet which means it is the default value of MongoDB
            return id.ToString() != "000000000000000000000000";
        }
    }
}
