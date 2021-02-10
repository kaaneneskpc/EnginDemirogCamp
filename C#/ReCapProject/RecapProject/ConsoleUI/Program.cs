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
            ColorManager colorManager = new ColorManager(new EfColorDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            FirstTest(carManager, colorManager);
        }

        private static void FirstTest(CarManager carManager, ColorManager colorManager)
        {
            foreach (var c in carManager.GetAll())
            {
                Console.WriteLine("Car Details : " + " " + c.BrandId + " " + c.ColorId + " " + c.DailyPrice + " " + c.ModelYear + " " + c.Description);
            }

            Console.WriteLine("-------------------ColorID------------------");
            foreach (var item in carManager.GetCarsByColorId(1))
            {
                Console.WriteLine(item.Description);
            }
            Console.WriteLine("-------------------CarDetails------------------");
            foreach (var item in carManager.GetCarDetails())
            {
                Console.WriteLine(item.DailyPrice+" "+item.BrandId);
            }
            Console.WriteLine("-------------------------------------------");
            foreach (var item in colorManager.GetById(1))
            {
                Console.WriteLine(item.ColorName);
            }
        }
    }
}
