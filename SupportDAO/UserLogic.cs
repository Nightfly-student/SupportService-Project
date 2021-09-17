using SupportDAL;
using SupportLogic;
using SupportModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportDAO
{
    public class UserLogic
    {
        private static UserLogic instance;
        private static MongoDatabase _connectedClient;

        private UserLogic()
        {
        }

        public void ConnectClient(MongoDatabase connectedClient)
        {
            _connectedClient = connectedClient;
        }
        public static UserLogic Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserLogic();
                }

                return instance;
            }
        }
        public void ConnectToDatabase(string databaseName)
        {
            _connectedClient.ConnectToDatabase(databaseName);
        }
        public void Connect()
        {
            ConnectClient(new MongoDatabase());
            _connectedClient.ConnectToDatabase("NoDesk");
        }
        public bool AuthUser(string username, string password)
        {
            List<Person> arr = _connectedClient.LoadFromCollection<Person>("Employees");

            foreach (Person p in arr)
            {
                if (p.Username == username && BCrypt.Net.BCrypt.Verify(password, p.Password))
                {
                    return true;
                }
            }
            return false;
        }

    }
}
