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
    public class UserDB
    {
        private MongoClient _mongoClient;
        private MongoServer _mongoServer;
        private MongoDatabase _mongoDatabase;
        private MongoCollection<User> _mongoCollection;
        private MongoCollection<Product> _mongoCollection1;

        public UserDB()
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
            _mongoCollection = _mongoDatabase.GetCollection<User>("user");

            _mongoCollection1 = _mongoDatabase.GetCollection<Product>("product");
        }
        public void InsertOne(String name, String email, String password)
        {
            var coll = _mongoDatabase.GetCollection<User>("user");  //指定寫入給"user"此collection  
            coll.Insert(new BsonDocument { { "uname", name }, { "umail", email }, { "upass", password } });

        }
        public bool find_the_user(String email)
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("shopping");
            var collection = database.GetCollection<User>("user");


            var filter = Builders<User>.Filter.Eq(x => x.umail, email);
            var results = collection.Find(filter).Count();

            if (results > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public async Task<String> get_user_name(String email)
        {

            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("shopping");
            var collection = database.GetCollection<User>("user");


            var filter = Builders<User>.Filter.Eq(x => x.umail, email);
            var list = await collection.Find(new BsonDocument()).ToListAsync();
            foreach (User dox in list)
            {
                return dox.uname;
            }
            return "ERROR";
        }

        public int login_success(String email, String password)
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("shopping");
            var collection = database.GetCollection<User>("user");


            var filter = Builders<User>.Filter.Eq(x => x.umail, email);
            var results = collection.Find(filter).Count();


            if (results > 0)
            {
                filter = Builders<User>.Filter.Eq(x => x.umail, email) & Builders<User>.Filter.Eq(x => x.upass, password);
                results = collection.Find(filter).Count();
                if (results > 0)
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
            else
            {
                return 1;
            }
        }

    }
}
