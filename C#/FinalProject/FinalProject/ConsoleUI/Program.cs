using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach(var product in productManager.GetByUnitPrice(50,10000))
            {
                Console.WriteLine(product.CategoryId+" "+product.ProductName+" "+product.UnitPrice+" "+product.UnitsInStock);
            }
        }
    }
}
