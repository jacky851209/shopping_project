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
    class ScoreDB
    {
        private BaseDB _BaseDB;

        public ScoreDB()
        {
            _BaseDB = BaseDB.getInstance();
        }

        public void add_score(String Product, String OwnerEmail, String BuyerEmail, int score)
        {
            var coll = _BaseDB.GetInsertCollection<Score>("shopping", "score");
            coll.Insert(new BsonDocument { { "ProductName", Product }, { "OwnerEmail", OwnerEmail }, { "BuyerEmail", BuyerEmail }, { "score", score } });
        }

        public bool find_buyer_is_scored(String Product, String OwnerEmail, String BuyerEmail)
        {
            var collection = _BaseDB.GetCollection<Score>("shopping", "score");

            var filter = Builders<Score>.Filter.Eq(x => x.ProductName, Product)
                & Builders<Score>.Filter.Eq(x => x.OwnerEmail, OwnerEmail)
                & Builders<Score>.Filter.Eq(x => x.BuyerEmail, BuyerEmail);
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

        public async void change_score(String Product, String OwnerEmail, String BuyerEmail, int score)
        {
            var collection = _BaseDB.GetCollection<Score>("shopping", "score");

            var filter = Builders<Score>.Filter.And(
                        Builders<Score>.Filter.Eq(p => p.ProductName, Product),
                        Builders<Score>.Filter.Eq(p => p.OwnerEmail, OwnerEmail),
                        Builders<Score>.Filter.Eq(p => p.BuyerEmail, BuyerEmail)
            );
            var result = await collection.FindOneAndUpdateAsync(
                                filter,
                                Builders<Score>.Update.Set("score", score)
                                );
        }
        public int get_person_count(String Product, String OwnerEmail)
        {
            var collection = _BaseDB.GetCollection<Score>("shopping", "score");

            var filter = Builders<Score>.Filter.And(
                        Builders<Score>.Filter.Eq(p => p.ProductName, Product),
                        Builders<Score>.Filter.Eq(p => p.OwnerEmail, OwnerEmail)
            );
            var results = collection.Find(filter).Count();
            return (int)results;
        }
        public async Task<List<Score>> get_person_score(String Product, String OwnerEmail)
        {
            var collection = _BaseDB.GetCollection<Score>("shopping", "score");

            var filter = Builders<Score>.Filter.And(
                        Builders<Score>.Filter.Eq(p => p.ProductName, Product),
                        Builders<Score>.Filter.Eq(p => p.OwnerEmail, OwnerEmail)
            );
            var list = await collection.Find(filter).ToListAsync();
            return list;
        }

        public async Task<int> get_score(String Product, String OwnerEmail, String BuyerEmail)
        {
            var collection = _BaseDB.GetCollection<Score>("shopping", "score");

            var filter = Builders<Score>.Filter.And(
                        Builders<Score>.Filter.Eq(p => p.ProductName, Product),
                        Builders<Score>.Filter.Eq(p => p.OwnerEmail, OwnerEmail),
                        Builders<Score>.Filter.Eq(p => p.BuyerEmail, BuyerEmail)
            );
            var list = await collection.Find(filter).ToListAsync();
            foreach (Score dox in list)
            {
                return dox.score;
            }
            return 0;
        }
    }
}
