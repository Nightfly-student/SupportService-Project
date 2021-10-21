using SupportDAL;
using SupportModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;

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

        public bool Exists(string username)
        {
            var records = _connectedClient.LoadFromCollection<Person>("Employees");
            foreach (var record in records)
            {
                if (record.Username.Equals(username))
                {
                    return true;
                }
            }
            return false;
        }

        public T GetEnumValue<T>(string str) where T : struct, IConvertible
        {
            if (!typeof(T).IsEnum)
            {
                throw new Exception("T must be an Enumeration type.");
            }
            T val = ((T[])Enum.GetValues(typeof(T)))[0];
            if (!string.IsNullOrEmpty(str))
            {
                foreach (T enumValue in (T[])Enum.GetValues(typeof(T)))
                {
                    if (enumValue.ToString().ToUpper().Equals(str.ToUpper()))
                    {
                        val = enumValue;
                        break;
                    }
                }
            }

            return val;
        }

        public List<Person> GetUsers()
        {
            var records = _connectedClient.LoadFromCollection<Person>("Employees");
            List<Person> peopleList = new List<Person>();
            foreach (var record in records)
            {
                peopleList.Add(record);
            }

            return peopleList;
        }
    }
}