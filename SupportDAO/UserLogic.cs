﻿using SupportDAL;
using SupportLogic;
using SupportModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupportDAO
{
    //Jelle Toonen//
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
        public Person AuthUser(string username, string password)
        {
            List<Person> arr = _connectedClient.LoadFromCollection<Person>("Employees");

            foreach (Person p in arr)
            {
                if (p.Username == username && BCrypt.Net.BCrypt.Verify(password, p.Password))
                {
                    return p;
                }
            }
            return null;
        }
        // Tim Roffelsen
        public List<Person> GetUsers()
        {
            var records = _connectedClient.LoadFromCollection<Person>("Employees");
            List<Person> peopleList = new List<Person>();
            foreach (var p in records)
            {
                peopleList.Add(p);
            }

            return peopleList;
        }
        public List<ListViewItem> UserCollection()
        {
            int counter = 0;
            var records = _connectedClient.LoadFromCollection<Person>("Employees");
            List<ListViewItem> items = new List<ListViewItem>();
            foreach (var record in records)
            {
                var count = _connectedClient.CountItemByName<Ticket>("Tickets", record.FirstName.ToString(), "MadeBy.FirstName");
                counter++;
                ListViewItem item = new ListViewItem(counter.ToString());
                item.SubItems.Add(record.Email);
                item.SubItems.Add(record.FirstName);
                item.SubItems.Add(record.LastName);
                item.SubItems.Add(count.ToString());
                items.Add(item);
            }
            return items;
        }
    }
}
