using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SupportDAL
{
    public class MongoDatabase
    {
        private const string DB_NAME = "dbname";
        private const string CONNECT_STRING = "mongodb+srv://dbAdmin:dbadminpass@cluster0.ddguq.mongodb.net/myFirstDatabase?retryWrites=true&w=majority";
        private MongoClient _client;
        private IMongoDatabase _db;

        public MongoDatabase()
        {
            _client = new MongoClient(CONNECT_STRING);
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
        public List<string> DisplayTables()
        {
            List<string> tableNames = new List<string>();
            foreach (BsonDocument collection in _db.ListCollectionsAsync().Result.ToListAsync<BsonDocument>()
                .Result)
            {
                string tableName = collection["name"].AsString;
                tableNames.Add(tableName);
            }

            return tableNames;
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
        public void InsertItem<T>(string table, T item)
        {
            var collection = _db.GetCollection<T>(table);
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
        public List<T> LoadAllItems<T>(string table)
        {
            var collection = _db.GetCollection<T>(table);

            return collection.Find(new BsonDocument()).ToList();
        }

        // load specific item by ID
        public T LoadItemById<T>(string table, Guid id)
        {
            var collection = _db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("Id", id);

            return collection.Find(filter).First();
        }

        //UPDATE (GEEN IDEE HOE HET WERKT)//

        /*public async Task UpdateDocument<T>(ObjectId Id, T item)
       {
           var startTime = DateTime.UtcNow;
           try
           {
               var bsonWriter = new BsonDocumentWriter(new BsonDocument(), BsonDocumentWriterSettings.Defaults);
               BsonSerializer.Serialize<GlobalModel_Root>(bsonWriter, GlobalModel.rootGM);
               var doc = bsonWriter.Document;
               var collection = _db.GetCollection<BsonDocument>(typeof(T).Name);
               var filter = Builders<BsonDocument>.Filter.Eq("_id", Id);
               var entity = collection.Find(filter).FirstOrDefault();
               using (var timeoutCancellationTokenSource = new CancellationTokenSource(TimeSpan.FromSeconds(60)))
               {
                   await collection.ReplaceOneAsync(filter, doc, null, timeoutCancellationTokenSource.Token);
               }
           }
           catch (OperationCanceledException ex)
           {
               var endTime = DateTime.UtcNow;
               var elapsed = endTime - startTime;
               Console.WriteLine("Operation was cancelled after {0} seconds.", elapsed.TotalSeconds);
           }
       }
       */
    }
}