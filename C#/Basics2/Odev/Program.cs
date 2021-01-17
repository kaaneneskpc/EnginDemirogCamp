using System;

namespace Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri m1 = new Musteri();

            m1.Name = "Kaan";
            m1.Surname = "KAPICI";
            m1.Price = 10000;

            Musteri m2 = new Musteri();

            m2.Name = "Ceren";
            m2.Surname = "YILMAZ";
            m2.Price = 15000;

            Musteri[] musteriler = new Musteri[] { m1, m2};

            MusteriManager manager = new MusteriManager();
            manager.Ekle(m1);
            manager.Ekle(m2);
            Console.WriteLine("----------------Musteriler Eklendi-------------");
            manager.Sil(m1);
            manager.Sil(m2);
            Console.WriteLine("----------------Musteriler Silindi-------------");
            manager.Listele(musteriler);
            Console.WriteLine("----------------Musteriler Listelendi-------------");

        }
    }
}
