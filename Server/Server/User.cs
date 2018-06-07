using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Server
{
    public class User
    {
        [BsonId]
        public ObjectId ID { get; set; }
        public string uname { get; set; }
        public string upass { get; set; }
        public string umail { get; set; }

    }
}
