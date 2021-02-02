using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;

        public InMemoryProductDal() //Constracter olusturuyoruz
        { //oracle, sql server, postgrade den geliyormus gibi simule ediyoruz
            _products = new List<Product>{
                new Product {ProductId =1, CategoryId=1, ProductName="Bardak", UnitPrice=15, UnitsInStock = 15 } ,
            new Product { ProductId =2, CategoryId=1, ProductName = "Kamera", UnitPrice = 500, UnitsInStock = 3 },
            new Product { ProductId =3, CategoryId=2, ProductName = "Telefon", UnitPrice = 1500, UnitsInStock = 2 },
            new Product { ProductId =4, CategoryId=2, ProductName = "Klavye", UnitPrice = 150, UnitsInStock = 65 },
            new Product { ProductId =5, CategoryId=2, ProductName = "Fare", UnitPrice = 85, UnitsInStock = 1 }
            };


        }
        public void Add(Product product) //urunu kaynaga ekleriz. Su an in memeory calistigimizdan listeye ekliyoruz
        {
            _products.Add(product);
        }

        public void Delete(Product product) //producttan istedigimi silmek istiyorum, onun icinde silmek istedigimiz urunun idsini ve referansini bulamk istiyoruz. Bu nedenle bir dongu yazabilirdik
        {

            //Product productToDelete = null;
            //foreach (var p in _products)

            //{if(product.ProductId == p.ProductId)
            //    {
            //        productToDelete = p; //p yi bulursan silinecek elemanin referans numarasi p 
            //     }

            //} //for dongusu yerine LINQ ile daha kolay yazabilirdik
            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId); //normalde gelmez gelmesi icin ampulden system linq lazim. SingleOrDefault products i tek tek dolasmaya yarar. Bu kod yukaridaki foreach`i yapiyor. Her p icin benim o an dolastigim urunun idsi buna esitse..
            _products.Remove(productToDelete);

        }

        public List<Product> GetAll() //veritabanindaki data business a verilmeli
        {
            return _products;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList(); //verilen sartlara uygun yeni bir liste olusturur
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId); //gonderdigim urun idsine sahip olan listedeki urunu bul
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}

        