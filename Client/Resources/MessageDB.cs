﻿using MongoDB.Bson;
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

        public void add_msg(String item, String email, String msg, String inputstream, String oemail)
        {
            var coll = _BaseDB.GetInsertCollection<Message>("shopping", "message");
            coll.Insert(new BsonDocument { { "ProductName", item }, { "BuyerEmail", email }, { "SendMessage", msg }, { "User_image", inputstream }, { "OwnerEmail", oemail } });
        }

        public int find_msg_is_exist(String item)
        {
            var collection = _BaseDB.GetCollection<Message>("shopping", "message");

            var filter = Builders<Message>.Filter.Eq(x => x.ProductName, item);
            var results = collection.Find(filter).Count();

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
