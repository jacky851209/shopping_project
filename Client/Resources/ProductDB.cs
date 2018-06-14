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
    class ProductDB
    {
        private BaseDB _BaseDB;

        public ProductDB()
        {
            _BaseDB = BaseDB.getInstance();
        }
        public void add_pro(String item, String info, String email, int price, int count, String image_path)
        {
            byte[] imageArray = System.IO.File.ReadAllBytes(image_path);
            string base64ImageRepresentation = Convert.ToBase64String(imageArray);

            var coll = _BaseDB.GetInsertCollection<Product>("shopping", "product");
            coll.Insert(new BsonDocument { { "ProductName", item }, { "Infomation", info }, { "OwnerEmail", email }, { "Price", price }, { "Count", count }, { "Product_image", base64ImageRepresentation }, { "Average_Score ", 0} });
        }

        public bool find_item_is_exist(String item, String email)
        {
            var collection = _BaseDB.GetCollection<Product>("shopping", "product");

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

        public int sell_product(String email)
        {
            var collection = _BaseDB.GetCollection<Product>("shopping", "product");

            var filter = Builders<Product>.Filter.Eq(x => x.OwnerEmail, email);
            var results = collection.Find(filter).Count();

            return (int)results;
        }

        public async Task<List<Product>> get_product(String email)
        {
            var collection = _BaseDB.GetCollection<Product>("shopping", "product");

            var filter = Builders<Product>.Filter.Eq(x => x.OwnerEmail, email);
            var list = await collection.Find(filter).ToListAsync();

            return list;
        }

        public async Task<List<Product>> get_allproduct()
        {
            var collection = _BaseDB.GetCollection<Product>("shopping", "product");

            var list = await collection.Find(_ => true).ToListAsync();

            return list;
        }

        public async Task<string> get_picture(String item, String email)
        {
            var collection = _BaseDB.GetCollection<Product>("shopping", "product");

            var filter = Builders<Product>.Filter.Eq(x => x.ProductName, item) & Builders<Product>.Filter.Eq(x => x.OwnerEmail, email);
            var list = await collection.Find(filter).ToListAsync();

            foreach (Product dox in list)
            {
                return dox.Product_image;
            }
            return "ERROR";
        }

        public async Task update_product(String email, String pro_name, String info, int price, int count, String image)
        {
            var collection = _BaseDB.GetCollection<Product>("shopping", "product");

            var filter = Builders<Product>.Filter.And(
                        Builders<Product>.Filter.Eq(p => p.ProductName, pro_name),
                        Builders<Product>.Filter.Eq(p => p.OwnerEmail, email)
            );
            var result = await collection.FindOneAndUpdateAsync(
                                filter,
                                Builders<Product>.Update.Set("Infomation", info).Set("Price", price).Set("Count", count).Set("Product_image", image)
                                );

        }

        public async Task buy_product(String email, String pro_name, int buy)
        {
            var collection = _BaseDB.GetCollection<Product>("shopping", "product");

            var filter = Builders<Product>.Filter.And(
                        Builders<Product>.Filter.Eq(p => p.ProductName, pro_name),
                        Builders<Product>.Filter.Eq(p => p.OwnerEmail, email)
            );
            var result = await collection.FindOneAndUpdateAsync(
                                filter,
                                Builders<Product>.Update.Set("Count", buy)
                                );

        }

        public async Task delete_product(String email, String pro_name)
        {
            var collection = _BaseDB.GetCollection<Product>("shopping", "product");

            var filter = Builders<Product>.Filter.And(
                        Builders<Product>.Filter.Eq(p => p.ProductName, pro_name),
                        Builders<Product>.Filter.Eq(p => p.OwnerEmail, email)
            );
            var DelMultiple = await collection.DeleteOneAsync(filter);

        }

        public async Task<List<Product>> search(String search, int price_type)
        {
            var collection = _BaseDB.GetCollection<Product>("shopping", "product");

            var filter = Builders<Product>.Filter.Regex(p => p.ProductName, search + ".*$");

            if (price_type == -1)
            {
                var DelMultiple = await collection.Find(filter).ToListAsync();
                return DelMultiple;
            }
            else if (price_type == 0)
            {
                var DelMultiple = await collection.Find(filter).Sort(Builders<Product>.Sort.Ascending("Price")).ToListAsync();
                return DelMultiple;
            }
            else if (price_type == 1)
            {
                var DelMultiple = await collection.Find(filter).Sort(Builders<Product>.Sort.Descending("Price")).ToListAsync();
                return DelMultiple;
            }
            else 
            {
                var DelMultiple = await collection.Find(filter).Sort(Builders<Product>.Sort.Descending("Average_Score")).ToListAsync();
                return DelMultiple;
            }

        }
        public async Task set_score(String email, String pro_name, double score)
        {
            var collection = _BaseDB.GetCollection<Product>("shopping", "product");

            var filter = Builders<Product>.Filter.And(
                        Builders<Product>.Filter.Eq(p => p.ProductName, pro_name),
                        Builders<Product>.Filter.Eq(p => p.OwnerEmail, email)
            );
            var result = await collection.FindOneAndUpdateAsync(
                                filter,
                                Builders<Product>.Update.Set("Average_Score", score)
                                );
        }
    }
}
