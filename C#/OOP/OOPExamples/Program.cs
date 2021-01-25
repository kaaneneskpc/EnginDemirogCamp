using System;

namespace OOPExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer c1 = new IndividualCustomer();
            c1.Name = "Kaan Enes";
            c1.Surname = "KAPICI";
            c1.CustomerNo = "12345";
            c1.TcNo = "22222222222";
            c1.Id = 1;

            CorporateCustomer c2 = new CorporateCustomer();
            c2.Id = 2;
            c2.CustomerNo = "54321";
            c2.CompanyName = "GDG";
            c2.TaxNo = "1234567890";

            Customers c3 = new IndividualCustomer();
            Customers c4 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(c1);
            customerManager.Add(c2);

        }
    }
}
