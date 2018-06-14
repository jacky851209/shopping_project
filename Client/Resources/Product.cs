using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace WindowsFormsApplication1.Resources
{
    class Product
    {
        [BsonId]
        public ObjectId ID { get; set; }
        public string ProductName { get; set; }
        public string Infomation { get; set; }
        public string OwnerEmail { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
        public string Product_image { get; set; }
        public double Average_Score { get; set; }
    }
}
