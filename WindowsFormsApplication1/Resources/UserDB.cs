using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Resources
{
    public class UserDB
    {
        private MongoClient _mongoClient;
        private MongoServer _mongoServer;
        private MongoDatabase _mongoDatabase;
        private MongoCollection<User> _mongoCollection;

        public UserDB()
        {
            // MongoDB 連線字串
            string connectionString = "mongodb://localhost";
            // 產生 MongoClient 物件
            _mongoClient = new MongoClient(connectionString);
            // 取得 MongoServer 物件
            _mongoServer = _mongoClient.GetServer();
            // 取得 MongoDatabase 物件
            _mongoDatabase = _mongoServer.GetDatabase("test");
            // 取得 Collection
            _mongoCollection = _mongoDatabase.GetCollection<User>("User");
        }
        public void InsertOne()
        {
            var coll = _mongoDatabase.GetCollection<BsonDocument>("user");  //指定寫入給"user"此collection  
            coll.Insert(new BsonDocument { { "uname", "k" }, { "umail", "K@gmail.com" }, { "upass", "k" } });   //新增一筆document，屬性name之值 = "cabintest" 

        }
    }
}
