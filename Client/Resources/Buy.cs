using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace WindowsFormsApplication1.Resources
{
    class Buy
    {
        [BsonId]
        public ObjectId ID { get; set; }
        public string BuyerEmail { get; set; }
        public string ProductName { get; set; }
        public int Count { get; set; }
        public int Price { get; set; }
    }
}
