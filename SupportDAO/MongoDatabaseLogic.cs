using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SupportDAL;
using SupportModel;

namespace SupportLogic
{
    public class MongoDatabaseLogic
    {
        private readonly MongoDatabase _connectedClient;

        public MongoDatabaseLogic(MongoDatabase connectedClient)
        {
            _connectedClient = connectedClient;
        }
        public List<ListViewItem> LoadFromCollection(string collectionName)
        {
            var records = _connectedClient.LoadFromCollection<Person>(collectionName);
            List<ListViewItem> items = new List<ListViewItem>();
            foreach (var record in records)
            {
                ListViewItem item = new ListViewItem(record.FirstName) { Tag = record.Id };
                item.SubItems.Add(record.LastName);
                item.SubItems.Add(collectionName);
                item.SubItems.Add(record.Email);
                item.SubItems.Add(record.DateOfBirth.ToString("yyyy/MM/dd"));
                item.SubItems.Add(record.PhoneNumber.ToString());
                item.SubItems.Add(record.WorkLocation);
                items.Add(item);
            }

            return items;
        }

        public void InsertItem<T>(string collectionName, T item)
        {
            _connectedClient.InsertItem(collectionName, item);
        }

        public void ConnectToDatabase(string databaseName)
        {
            _connectedClient.ConnectToDatabase(databaseName);
        }

        public List<string> DisplayCollections()
        {
            return _connectedClient.DisplayCollections();
        }
    }
}
