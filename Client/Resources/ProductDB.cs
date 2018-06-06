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
    class ProductDB
    {
        private MongoClient _mongoClient;
        private MongoServer _mongoServer;
        private MongoDatabase _mongoDatabase;
        private MongoCollection<Product> _mongoCollection1;

        public ProductDB()
        {
            // MongoDB 連線字串
            string connectionString = "mongodb://localhost";
            // 產生 MongoClient 物件
            _mongoClient = new MongoClient(connectionString);
            // 取得 MongoServer 物件
            _mongoServer = _mongoClient.GetServer();
            // 取得 MongoDatabase 物件
            _mongoDatabase = _mongoServer.GetDatabase("shopping");
            // 取得 Collection
            _mongoCollection1 = _mongoDatabase.GetCollection<Product>("product");
        }
        public void add_pro(String item, String info, String email, int price, int count, String image_path)
        {
            byte[] imageArray = System.IO.File.ReadAllBytes(image_path);
            string base64ImageRepresentation = Convert.ToBase64String(imageArray);
            var coll = _mongoDatabase.GetCollection<Product>("product");
            coll.Insert(new BsonDocument { { "ProductName", item }, { "Infomation", info }, { "OwnerEmail", email }, { "Price", price }, { "Count", count }, { "Product_image", base64ImageRepresentation } });
        }

        public bool find_item_is_exist(String item, String email)
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("shopping");
            var collection = database.GetCollection<Product>("product");


            var filter = Builders<Product>.Filter.Eq(x => x.ProductName, item) & Builders<Product>.Filter.Eq(x => x.OwnerEmail, email);
            var results = collection.Find(filter).Count();

            if (results > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public async Task<string> get_picture(String item, String email)
        {

            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("shopping");
            var collection = database.GetCollection<Product>("product");

            var filter = Builders<Product>.Filter.Eq(x => x.ProductName, item) & Builders<Product>.Filter.Eq(x => x.OwnerEmail, email);
            var list = await collection.Find(filter).ToListAsync();

            foreach (Product dox in list)
            {
                return dox.Product_image;
            }
            return "ERROR";
        }
    }
}