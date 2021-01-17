using System;
using System.Collections.Generic;
using System.Text;

namespace Odev
{
    class MusteriManager
    {

        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Musteri added." + " " + musteri.Name);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Musteri Deleted" + " " + musteri.Name);
        }
        public void Listele(Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Name + " " + musteri.Surname + " " + musteri.Price);
            }
        }
    }
}
