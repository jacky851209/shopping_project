﻿using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace WindowsFormsApplication1.Resources
{
    class Score
    {
        [BsonId]
        public ObjectId ID { get; set; }
        public string ProductName { get; set; }
        public string OwnerEmail { get; set; }
        public string BuyerEmail { get; set; }
        public int score { get; set; }
    }
}