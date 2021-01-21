using System;
using System.Collections.Generic;
using System.Text;

namespace Intro3
{
    class ProductService
    {
        //encapsulation
        public void Add(Product product)
        {
            product.ProductName = "Table";
            Console.WriteLine(product.ProductName +" "+"added.");
        }
        public void Update(Product product)
        {
            product.UnitPrice = 150;
            Console.WriteLine(product.ProductName + " " + "updated.");
        }
        public void Delete(Product product)
        {
            product.ProductName = "Empty";
            Console.WriteLine(product.ProductName + " " + "deleted.");
        }

    }
}
