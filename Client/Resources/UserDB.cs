using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver.GridFS;

namespace WindowsFormsApplication1.Resources
{
    public class UserDB
    {
        private BaseDB _BaseDB;

        private MongoClient _mongoClient;
        private MongoServer _mongoServer;
        private MongoDatabase _mongoDatabase;
        private MongoCollection<User> _mongoCollection;
        private MongoCollection<Product> _mongoCollection1;

        public UserDB()
        {
            _BaseDB = BaseDB.getInstance();

            // MongoDB 連線字串
            string connectionString = "mongodb://localhost";
            // 產生 MongoClient 物件
            _mongoClient = new MongoClient(connectionString);
            // 取得 MongoServer 物件
            _mongoServer = _mongoClient.GetServer();
            // 取得 MongoDatabase 物件
            _mongoDatabase = _mongoServer.GetDatabase("shopping");
            // 取得 Collection
            _mongoCollection = _mongoDatabase.GetCollection<User>("user");

            _mongoCollection1 = _mongoDatabase.GetCollection<Product>("product");

           
        }
        public void InsertOne(String name, String email, String password)
        {
            var coll = _BaseDB.GetInsertCollection<User>("shopping", "user");//指定寫入給"user"此collection  
            coll.Insert(new BsonDocument { { "uname", name }, { "umail", email }, { "upass", password }, { "uimage", "/9j/4AAQSkZJRgABAQEASABIAAD/2wBDAAICAgICAQICAgIDAgIDAwYEAwMDAwcFBQQGCAcJCAgHCAgJCg0LCQoMCggICw8LDA0ODg8OCQsQERAOEQ0ODg7/2wBDAQIDAwMDAwcEBAcOCQgJDg4ODg4ODg4ODg4ODg4ODg4ODg4ODg4ODg4ODg4ODg4ODg4ODg4ODg4ODg4ODg4ODg7/wAARCABQAFADASIAAhEBAxEB/8QAHwAAAQUBAQEBAQEAAAAAAAAAAAECAwQFBgcICQoL/8QAtRAAAgEDAwIEAwUFBAQAAAF9AQIDAAQRBRIhMUEGE1FhByJxFDKBkaEII0KxwRVS0fAkM2JyggkKFhcYGRolJicoKSo0NTY3ODk6Q0RFRkdISUpTVFVWV1hZWmNkZWZnaGlqc3R1dnd4eXqDhIWGh4iJipKTlJWWl5iZmqKjpKWmp6ipqrKztLW2t7i5usLDxMXGx8jJytLT1NXW19jZ2uHi4+Tl5ufo6erx8vP09fb3+Pn6/8QAHwEAAwEBAQEBAQEBAQAAAAAAAAECAwQFBgcICQoL/8QAtREAAgECBAQDBAcFBAQAAQJ3AAECAxEEBSExBhJBUQdhcRMiMoEIFEKRobHBCSMzUvAVYnLRChYkNOEl8RcYGRomJygpKjU2Nzg5OkNERUZHSElKU1RVVldYWVpjZGVmZ2hpanN0dXZ3eHl6goOEhYaHiImKkpOUlZaXmJmaoqOkpaanqKmqsrO0tba3uLm6wsPExcbHyMnK0tPU1dbX2Nna4uPk5ebn6Onq8vP09fb3+Pn6/9oADAMBAAIRAxEAPwD9MKKKK+sPHCiivTvAvgePWoBq+rBv7ND4ggBIM5B5JP8Adzxx15/HOdSNOPNIqMXJ2R55Z2F9qNx5Wn2c95IOohiLY+uOB+NdVD8P/Ez2TXFxbwadbopZ3urkLtA6k4zgfWvpC2tbazs0t7S3jtoEHyxxIFUfgKkkjjmt5IZo1lidSro65DA9QR3FeVLGSb91HYqC6s+OGXbKyhlkAYgMvRvce1Nr1Txx4DTS7aTWNFU/YF5uLbr5I/vL/s+o7fTp5XXqU6kakeaJxyi4uzCiiitSQooooAO1fVnhNBH8NNCVVCj7FGcD3UGvlPtX1l4bUr8PtDUqVIsYsgjGPkFeZjfhR1UN2bVFFFeMdxU1BFk0K9jYBlaB1II4IKmvjxf9Wv0r7GvP+QTdf9cW/ka+OV/1a/SvXwW0vkcdfdDqKKK9U4wooooAdHJ5VxHL/ccN+RzX2PHIs1vHLGwaN1DKR3Br42r6Q+HOofbvhjaxNJ5k1pI0DZOSADlf/HSPyrzMbG8VLsdVB6tHeUUUV4x3BXyDqky3HifUrhcbZLuRlI9C5xX0h441T+y/hpqMqSGO4mUQQlTg7m44+gyfwr5h7V7GCjo5HHXeqQUUUV6hxhRRRQAV6V8LZLhfiDcQxzMtu1ozTRjoxBAU/UbjXmucDnivoj4c6FDp/gm31KW2VNSvAWaUj5/LJ+VfYYAOPeuPEyUaTv1NqSbmeiUUUV8+ekeG/FqeT+39HtvMbyRA8nl543bsZ+uK8lr6G+JWix33gd9Sit1e+siG8wD5vKz8w9xzn8K+ec5HFfQYWSdFW6HnVU1MKKKK7DAcqtJKscatJIxwqKMlj6ADrXoWi/DXXNSCzagRo9qe0g3Sn/gPb8T+FexeH/CekeHbVfskPnXhGJLuUAyN+PYewrpq8epjG9IHbGivtHI6N4H8PaLtkisxeXQ/5eLr52z7DoPwFddRRXmylKTvJ3OpJLYKKKKkYdq5DWPA3h3WN0klmLO6P/Le1/dt+I6H8RXX0VUZSi7xdhNJ7nz1rXwz1rTw02msur24/hQbJR/wE8H8D+FedyRyQ3DwzRvDMhw8cilWX6g19k1g654b0nxBYtFf2ymbbiO4QYkj9wf6HivSp4yS0nqc0qKfwn//2Q==" } });

        }
        public bool find_the_user(String email)
        {
            var collection = _BaseDB.GetCollection<User>("shopping", "user");


            var filter = Builders<User>.Filter.Eq(x => x.umail, email);
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

        public async Task<string> get_user_name(String email)
        {
            var collection = _BaseDB.GetCollection<User>("shopping", "user");

            var filter = Builders<User>.Filter.Eq(x => x.umail, email);
            var list = await collection.Find(filter).ToListAsync();
            
            foreach (User dox in list)
            {
                return dox.uname;
            }
            return "ERROR";
        }

        public async Task<string> get_password(String email)
        {
            var collection = _BaseDB.GetCollection<User>("shopping", "user");

            var filter = Builders<User>.Filter.Eq(x => x.umail, email);
            var list = await collection.Find(filter).ToListAsync();

            foreach (User dox in list)
            {
                return dox.upass;
            }
            return "ERROR";
        }

        public int login_success(String email, String password)
        {
            var collection = _BaseDB.GetCollection<User>("shopping", "user");

            var filter = Builders<User>.Filter.Eq(x => x.umail, email);
            var results = collection.Find(filter).Count();


            if (results > 0)
            {
                filter = Builders<User>.Filter.Eq(x => x.umail, email) & Builders<User>.Filter.Eq(x => x.upass, password);
                results = collection.Find(filter).Count();
                if (results > 0)
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
            else
            {
                return 1;
            }
        }

        public async Task change_password(String email, String pass)
        {
            var collection = _BaseDB.GetCollection<User>("shopping", "user");

            var result = await collection.FindOneAndUpdateAsync(
                                Builders<User>.Filter.Eq("umail", email),
                                Builders<User>.Update.Set("upass", pass)
                                );

        }

        public async Task add_picture(String email, String image_path)
        {
            byte[] imageArray = System.IO.File.ReadAllBytes(image_path);
            string base64ImageRepresentation = Convert.ToBase64String(imageArray);

            var collection = _BaseDB.GetCollection<User>("shopping", "user");

            var result = await collection.FindOneAndUpdateAsync(
                                Builders<User>.Filter.Eq("umail", email),
                                Builders<User>.Update.Set("uimage", base64ImageRepresentation)
                                );

        }

        public async Task<string> get_picture(String email)
        {
            var collection = _BaseDB.GetCollection<User>("shopping", "user");

            var filter = Builders<User>.Filter.Eq(x => x.umail, email);
            var list = await collection.Find(filter).ToListAsync();

            foreach (User dox in list)
            {
                return dox.uimage;
            }
            return "ERROR";
        }

    }
}
