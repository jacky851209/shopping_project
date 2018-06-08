using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver.GridFS;


namespace WindowsFormsApplication1.Resources
{

    class BuyDB
    {
        private MongoClient _mongoClient;
        private MongoServer _mongoServer;
        private MongoDatabase _mongoDatabase;
        private MongoCollection<Buy> _mongoCollection1;

        public BuyDB()
        {
            // MongoDB 連線字串
            string connectionString = "mongodb://localhost";
            // 產生 MongoClient 物件
            _mongoClient = new MongoClient(connectionString);
            // 取得 MongoServer 物件
            _mongoServer = _mongoClient.GetServer();
            // 取得 MongoDatabase 物件
            _mongoDatabase = _mongoServer.GetDatabase("shopping");
            // 取得 Collection
            _mongoCollection1 = _mongoDatabase.GetCollection<Buy>("buy");
        }

        public void add_buy(String buyeremail, String item, int price, int count)
        {
            var coll = _mongoDatabase.GetCollection<Buy>("buy");
            coll.Insert(new BsonDocument { { "BuyerEmail", buyeremail }, { "ProductName", item }, { "Price", price }, { "Count", count } });
        }

        public int order_count(String email)
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("shopping");
            var collection = database.GetCollection<Buy>("buy");


            var filter = Builders<Buy>.Filter.Eq(x => x.BuyerEmail, email);
            var results = collection.Find(filter).Count();

            return (int)results;
        }

        public async Task<List<Buy>> get_order(String email)
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("shopping");
            var collection = database.GetCollection<Buy>("buy");

            var filter = Builders<Buy>.Filter.Eq(x => x.BuyerEmail, email);
            var list = await collection.Find(filter).ToListAsync();

            return list;
        }
    }
}
