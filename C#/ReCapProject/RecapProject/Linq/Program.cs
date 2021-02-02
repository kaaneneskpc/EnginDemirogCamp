using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId=1,CategoryName="PC" },
                new Category{CategoryId=2,CategoryName="Phone" },
            };
            List<Product> products = new List<Product>
            {
                new Product{ProductId=1,CategoryId=1,ProductName="HP",QuantityPerUnit="16 GB Ram",UnitPrice=7999,UnitsInStock=10},
                new Product{ProductId=2,CategoryId=1,ProductName="Casper",QuantityPerUnit="32 GB Ram",UnitPrice=8999,UnitsInStock=1},
                new Product{ProductId=3,CategoryId=2,ProductName="Iphone",QuantityPerUnit="16 GB Ram",UnitPrice=9999,UnitsInStock=0},
                new Product{ProductId=4,CategoryId=2,ProductName="Samsung",QuantityPerUnit="16 GB Ram",UnitPrice=6999,UnitsInStock=7},
            };

            /*var result = GetProducts(products);
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }*/

            var result = products.Any(products => products.ProductName == "Dell");
            var resultFind = products.Find(p => p.ProductId == 3);
            var price = products.Where(p => p.UnitPrice > 6000).OrderByDescending(p => p.UnitPrice).ThenByDescending(p=>p.ProductName);
            foreach (var item in price)
            {
                Console.WriteLine(item.ProductName);
            }
            Console.WriteLine(result);
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine(resultFind.ProductName);
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("---------------------------------------------------");

            var resultt = from p in products
                         select p;
            foreach (var item in resultt)
            {
                Console.WriteLine(item.ProductName);
            }
            Console.WriteLine("---------------------------------------------------");

            var result2 = from p in products
                          where p.UnitPrice > 6000
                          orderby p.UnitPrice descending,p.ProductName ascending
                          select p;
            foreach (var item in result2)
            {
                Console.WriteLine(item.ProductName);
            }
            Console.WriteLine("---------------------------------------------------");

        }
        /*
        static List<Product> GetProducts(List<Product> products)
        {
            return products.Where(p => p.UnitPrice > 7000 && p.UnitsInStock > 3).ToList();
        }*/


        
        
    }
}
