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
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var c in carManager.GetAll())
            {
                Console.WriteLine("Car Details : "+" "+c.BrandId+" "+c.ColorId+" "+c.DailyPrice+" "+c.ModelYear+" "+c.Description);
            }

            Console.WriteLine("-------------------ColorID------------------");
            foreach (var item in carManager.GetCarsByColorId(1))
            {
                Console.WriteLine(item.Description);
            }
            Console.WriteLine("-------------------BrandID------------------");
            foreach (var item in carManager.GetCarsByBrandId(2))
            {
                Console.WriteLine(item.ModelYear);
            }
        }
    }
}
