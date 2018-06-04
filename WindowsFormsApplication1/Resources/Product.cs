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
        public string ProductName { get; set; }
        public string Owner { get; set; }
        public decimal Price { get; set; }
        public decimal Count { get; set; }
    }
}
