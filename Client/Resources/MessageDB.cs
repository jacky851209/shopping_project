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
    class MessageDB
    {
        private BaseDB _BaseDB;

        public MessageDB()
        {
            _BaseDB = BaseDB.getInstance();
        }
        public void set_message(String Product, String OwnerEmail, String BuyerEmail, String message)
        {
            var coll = _BaseDB.GetInsertCollection<Message>("shopping", "message");
            coll.Insert(new BsonDocument { { "ProductName", Product }, { "BuyerEmail", BuyerEmail }, { "SendMessage", message }, { "OwnerEmail", OwnerEmail } });
        }
        public int find_msg_is_exist(String item)
        {
            var collection = _BaseDB.GetCollection<Message>("shopping", "message");

            var filter = Builders<Message>.Filter.Eq(x => x.ProductName, item);
            var results =  collection.Find(filter).Count();

            return (int)results;
        }

        public async Task<List<Message>> get_msg(String item)
        {
            var collection = _BaseDB.GetCollection<Message>("shopping", "message");

            var filter = Builders<Message>.Filter.Eq(x => x.ProductName, item);
            var list = await collection.Find(filter).ToListAsync();

            return list;
        }

      

    }
}
