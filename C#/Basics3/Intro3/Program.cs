using System;

namespace Intro3
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = " ";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product {Id = 2, CategoryId = 5,ProductName ="Pen", UnitsInStock = 4, UnitPrice =10 };

            ProductService productService = new ProductService();
            productService.Add(product1);
            productService.Update(product2);
            productService.Delete(product2);

        }
    }
}
