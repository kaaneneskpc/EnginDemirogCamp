using System;

namespace Intro2
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Name = "Apple";
            urun1.Price = 1.99;
            urun1.Detail = "Amasya Apple";
            urun1.Stock = 120;

            Urun urun2 = new Urun();
            urun2.Name = "Watermelon";
            urun2.Price = 2.99;
            urun2.Detail = "Diyabakir Watermelon";
            urun2.Stock = 100;

            /*Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Name + " - " + urun.Price + " - " + urun.Detail);
            }
            */
            Console.WriteLine("-----------Methods--------------");

            SepetManager manager = new SepetManager();
            manager.Add(urun1);
            manager.Add(urun2);

        }
    }
}
