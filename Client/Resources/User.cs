using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace WindowsFormsApplication1.Resources
{
    public class User
    {
        [BsonId]
        public ObjectId ID { get; set; }
        public string uname { get; set; }
        public string upass { get; set; }
        public string umail { get; set; }
        public string uimage { get; set; }
    }
}
