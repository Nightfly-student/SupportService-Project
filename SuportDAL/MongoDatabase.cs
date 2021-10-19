using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;

namespace SupportDAL
{
    public class MongoDatabase
    {
        private MongoClient _client;
        private IMongoDatabase _db;

        public MongoDatabase()
        {
            _client = new MongoClient(ConfigurationManager.ConnectionStrings["MongoConnection"].ConnectionString);
        }

        // connect to database
        public void ConnectToDatabase(string database)
        {
            _db = _client.GetDatabase(database);
        }

        // get list of databases
        public List<string> DisplayDatabases()
        {
            List<string> databaseNames = new List<string>();
            using var cursor = _client.ListDatabases();
            while (cursor.MoveNext())
            {
                foreach (var bsonDocument in cursor.Current)
                {
                    databaseNames.Add((string)bsonDocument["name"]);
                }
            }
            return databaseNames;
        }

        // get list of tables within database
        public List<string> DisplayCollections()
        {
            List<string> collectionNames = new List<string>();
            foreach (BsonDocument collection in _db.ListCollectionsAsync().Result.ToListAsync<BsonDocument>()
                .Result)
            {
                string tableName = collection["name"].AsString;
                collectionNames.Add(tableName);
            }

            return collectionNames;
        }

        public string GetDatabaseName()
        {
            return _db?.DatabaseNamespace.DatabaseName;
        }

        //Add a BSON document from a json string
        public void Add(string json, string collectionName)
        {
            var document = BsonSerializer.Deserialize<BsonDocument>(json);
            var collection = _db.GetCollection<BsonDocument>(collectionName);
            collection.InsertOne(document);
        }

        // insert an item into database
        public void InsertItem<T>(string collectionName, T item)
        {
            var collection = _db.GetCollection<T>(collectionName);
            collection.InsertOne(item);
        }

        //Add an item of the given type
        public void Add<T>(T item) where T : class, new()
        {
            _db.GetCollection<T>(typeof(T).Name).InsertOne(item);
        }

        public void Delete<T>(T item) where T : class, new()
        {
            //WorkAround for DeleteOne parameter
            ObjectFilterDefinition<T> filter = new ObjectFilterDefinition<T>(item);
            // Remove the object.
            _db.GetCollection<T>(typeof(T).Name).FindOneAndDelete(filter);
        }

        // load all items from database
        public List<T> LoadFromCollection<T>(string collectionName)
        {
            var collection = _db.GetCollection<T>(collectionName);

            return collection.Find(new BsonDocument()).ToList();
        }

        // load specific item by ID
        public T LoadItemById<T>(string collectionName, ObjectId id)
        {
            var collection = _db.GetCollection<T>(collectionName);
            var filter = Builders<T>.Filter.Eq("Id", id);

            return collection.Find(filter).First();
        }
        //Jelle TOonen tel de items op en return het (#tickets)//
        public int CountItemByName<T>(string collectionName, string item, string name)
        {
            var collection = _db.GetCollection<T>(collectionName);
            var filter = Builders<T>.Filter.Eq(name, item);
            var count = collection.Find(filter).CountDocuments();
            return int.Parse(count.ToString());
        }
        public void DeleteItemById<T>(string collectionName, ObjectId id)
        {
            var collection = _db.GetCollection<T>(collectionName);
            var filter = Builders<T>.Filter.Eq("Id", id);

            collection.DeleteOne(filter);
        }

        public static BsonObjectId Parse(string s)
        {
            return new BsonObjectId(ObjectId.Parse(s));
        }
    }
}