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
        private BaseDB _BaseDB;

        public BuyDB()
        {
            _BaseDB = BaseDB.getInstance();
        }

        public void add_buy(String buyeremail, String item, int price, int count,String owneremail)
        {
            var coll = _BaseDB.GetInsertCollection<Buy>("shopping", "buy");
            coll.Insert(new BsonDocument { { "BuyerEmail", buyeremail }, { "ProductName", item }, { "Price", price }, { "Count", count }, { "Oweneremail", owneremail}});
        }

        public int order_count(String email)
        {
            var collection = _BaseDB.GetCollection<Buy>("shopping","buy");

            var filter = Builders<Buy>.Filter.Eq(x => x.BuyerEmail, email);
            var results = collection.Find(filter).Count();

            return (int)results;
        }

        public async Task<List<Buy>> get_order(String email)
        {
            var collection = _BaseDB.GetCollection<Buy>("shopping", "buy");

            var filter = Builders<Buy>.Filter.Eq(x => x.BuyerEmail, email);
            var list = await collection.Find(filter).ToListAsync();

            return list;
        }

        public int howmanybuyer(String email)
        {
            var collection = _BaseDB.GetCollection<Buy>("shopping", "buy");

            var filter = Builders<Buy>.Filter.Eq(x => x.Oweneremail, email);
            var results = collection.Find(filter).Count();

            return (int)results;
        }

        public async Task<List<Buy>> order_notify(String email)
        {
            var collection = _BaseDB.GetCollection<Buy>("shopping", "buy");

            var filter = Builders<Buy>.Filter.Eq(x => x.Oweneremail, email);
            var list = await collection.Find(filter).ToListAsync();

            return list;
        }

    }
}
