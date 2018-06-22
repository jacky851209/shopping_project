using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Resources
{
    class BaseDB
    {
        static private readonly Object oLock = new Object();
        static private BaseDB self = null;

        private MongoClient _mongoClient;
        private MongoServer _mongoServer;
        private MongoDatabase _mongoDatabase;

        //禁止外面使用new來得到實體  改用getInstance
        private BaseDB()
        {
            // MongoDB 連線字串
            string connectionString = "mongodb://140.138.145.58:27017";
            // 產生 MongoClient 物件
            _mongoClient = new MongoClient(connectionString);
            // 取得 MongoServer 物件
            _mongoServer = _mongoClient.GetServer();
        }

        //用來得到BaseDB實體
        static public BaseDB getInstance()
        {
            if(self == null)
            {
                lock(oLock)
                {
                    if (self == null)
                    {
                        self = new BaseDB();
                    }
                }
            }
            return self;
        }

        //查詢用這個
        public IMongoCollection<T> GetCollection<T>(string dataBase, string collection)
        {
            var _database = _mongoClient.GetDatabase(dataBase);
            var _collection = _database.GetCollection<T>(collection);

            return _collection;
        }

        //插入新資料用這個
        public MongoCollection<T> GetInsertCollection<T>(string dataBase, string collection)
        {
            var _database = _mongoServer.GetDatabase(dataBase);
            var _collection = _database.GetCollection<T>(collection);

            return _collection;
        }
    }
}
