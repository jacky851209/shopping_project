using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace Server
{
    class Product
    {
        public string ProductName { get; set; }
        public string Infomation { get; set; }
        public string Ownername { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }

    }
}
