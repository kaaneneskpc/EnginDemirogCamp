using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var c in carManager.GetAll())
            {
                Console.WriteLine("Car Details : "+" "+c.BrandId+" "+c.ColorId+" "+c.DailyPrice+" "+c.ModelYear+" "+c.Description);
            }
        }
    }
}
