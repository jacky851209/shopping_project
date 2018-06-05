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
    class ProductDB
    {
        private MongoClient _mongoClient;
        private MongoServer _mongoServer;
        private MongoDatabase _mongoDatabase;
        private MongoCollection<Product> _mongoCollection1;

        public ProductDB()
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
            _mongoCollection1 = _mongoDatabase.GetCollection<Product>("Product");
        }
        public void add_pro(String item, String info, String ownername, int price, int count)
        {
            var coll = _mongoDatabase.GetCollection<Product>("product");
            coll.Insert(new BsonDocument { { "ProductName", item }, { "Infomation", info }, { "Ownername", ownername }, { "Price", price }, { "Owner", count } });
        }
    }
}
