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
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string Email { get; set; }
        public string ProductName { get; set; }

    }
}
