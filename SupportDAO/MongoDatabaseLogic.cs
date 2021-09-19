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
        private static MongoDatabaseLogic instance;
        private static MongoDatabase _connectedClient;

        private MongoDatabaseLogic()
        {
        }

        public void ConnectClient(MongoDatabase connectedClient)
        {
            _connectedClient = connectedClient;
        }
        public static MongoDatabaseLogic Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MongoDatabaseLogic();
                }

                return instance;
            }
        }
        public List<ListViewItem> ListViewItemsFromCollection(string collectionName)
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

        public string GetEnumName<T>(T value)
        {
            Type type = value.GetType();
            string name = Enum.GetName(type, value);
            if (name == null) return value.ToString();
            FieldInfo fieldInfo = type.GetField(name);
            if (fieldInfo == null) return value.ToString();
            if (Attribute.GetCustomAttribute(fieldInfo,
                typeof(DescriptionAttribute)) is DescriptionAttribute attr)
            {
                return attr.Description;
            }
            return value.ToString();
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

        public bool Exists(string username)
        {
            var records = _connectedClient.LoadFromCollection<Person>("Employees");
            foreach(var record in records)
            {
                if (record.Username.Equals(username))
                {
                    return true;
                }
            }
            return false;
        }
        ///User Management Screen (Should be in UserLogic)
        public List<ListViewItem> UserCollection()
        {
            int counter = 0;
            var records = _connectedClient.LoadFromCollection<Person>("Employees");
            List<ListViewItem> items = new List<ListViewItem>();
            foreach (var record in records)
            {
                counter++;
                ListViewItem item = new ListViewItem(counter.ToString());
                item.SubItems.Add(record.Email);
                item.SubItems.Add(record.FirstName);
                item.SubItems.Add(record.LastName);
                item.SubItems.Add(record.WorkLocation);
                items.Add(item);
            }
            return items;
        }

        
    }
}
