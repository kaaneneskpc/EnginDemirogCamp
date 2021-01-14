using System;

namespace ClassStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Ürün ü1 = new Ürün();
            ü1.ürünAdi = "Iphone";
            ü1.ürünTipi = "Telefon";
            ü1.ürünFiyat = 8000;

            Ürün ü2 = new Ürün();
            ü2.ürünAdi = "Ipad";
            ü2.ürünTipi = "Tablet";
            ü2.ürünFiyat = 3000;

            Ürün ü3 = new Ürün();
            ü3.ürünAdi = "MacBook";
            ü3.ürünTipi = "PC";
            ü3.ürünFiyat = 12000;



            Ürün[] ürünler = { ü1, ü2, ü3 };

            foreach (var ürün in ürünler)
            {
                Console.WriteLine(ürün.ürünAdi + " : " + ürün.ürünFiyat + " = " + ürün.ürünTipi);
            }
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            for (int i = 0; i < ürünler.Length; i++)
            {
                Console.WriteLine(ürünler[i].ürünAdi + " : " + ürünler[i].ürünFiyat + " = " + ürünler[i].ürünTipi);

            }


        }
    }

    class Ürün
    {
        public string ürünAdi { get; set; }
        public string ürünTipi { get; set; }
        public int ürünFiyat { get; set; }
    }
}
