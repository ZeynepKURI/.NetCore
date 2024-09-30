using System;
using DataAccess.Abstract;
using Entites.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal

    {
        List<Product> _products;
            public InMemoryProductDal()
        {

            // Oraclee ,Sql Server, MongoDb
            _products = new List<Product> {
                new Product{ProductId=1,CategoyId=1,ProductName="Bardak",UnitPrice=15,UnitsInStock=15 },
                new Product{ProductId=2,CategoyId=1,ProductName="Kamera",UnitPrice=134,UnitsInStock=23 },
                new Product{ProductId=3,CategoyId=2,ProductName="Telefon",UnitPrice=159,UnitsInStock=17 },
                new Product{ProductId=4,CategoyId=2,ProductName="Klavye",UnitPrice=165,UnitsInStock=67 },
                new Product{ProductId=5,CategoyId=2,ProductName="Fare",UnitPrice=75,UnitsInStock=165 },

            };    
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //lınQ sql gibi filtreleme
           
                           //foreach döngüsünü yapar.SingleOrDefault
          Product productToDelete = _products.SingleOrDefault(p =>p.ProductId==product.ProductId);

            _products.Remove(product);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
         return _products.Where(p => p.CategoyId == categoryId).ToList();
        }

        public void Update(Product product)
        {

            //Gönderdiğin ürün id'sine sahip olan listedekii ürünü bul.
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoyId = product.CategoyId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}

