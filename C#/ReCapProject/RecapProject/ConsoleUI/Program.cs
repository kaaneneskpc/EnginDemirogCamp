using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            CarManager carManager = new CarManager(new EfCarDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            UserManager userManager = new UserManager(new EfUserDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            //FirstTest(carManager, colorManager);

            Console.WriteLine("-------------------------------------------");

            customerManager.Add(new Customer { CustomerId = 5, UserId = 5, CompanyName = "THY" });
            Console.WriteLine("-------------------Rental=CarID------------------");
            foreach (var item in rentalManager.GetRentalByCarId(1).Data)
            {
                Console.WriteLine(item.CarId+" "+item.RentDate+" "+item.ReturnDate);
            }
            Console.WriteLine("-------------------Rental=CustomerID------------------");
            foreach (var item in rentalManager.GetRentalByCustomerId(2).Data)
            {
                Console.WriteLine(item.CustomerId + " " + item.RentDate + " " + item.ReturnDate);
            }
            Console.WriteLine("-------------------Rentals-----------------");
            foreach (var item in rentalManager.GetRentalDetails().Data)
            {
                Console.WriteLine(item.CustomerId + " " + item.RentDate + " " + item.ReturnDate);
            }
        }

        private static void FirstTest(CarManager carManager, ColorManager colorManager)
        {
            foreach (var c in carManager.GetAll().Data)
            {
                Console.WriteLine("Car Details : " + " " + c.BrandId + " " + c.ColorId + " " + c.DailyPrice + " " + c.ModelYear + " " + c.Description);
            }

            Console.WriteLine("-------------------ColorID------------------");
            foreach (var item in carManager.GetCarsByColorId(1).Data)
            {
                Console.WriteLine(item.Description);
            }
            Console.WriteLine("-------------------CarDetails------------------");
            foreach (var item in carManager.GetCarDetails().Data)

            {
                Console.WriteLine(item.DailyPrice+" "+item.BrandId);
            }
            Console.WriteLine("-------------------------------------------");
            foreach (var item in colorManager.GetById(1).Data)
            {
                Console.WriteLine(item.ColorName);
            }*/

        }
    }
}
