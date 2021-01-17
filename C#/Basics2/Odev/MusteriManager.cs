using System;
using System.Collections.Generic;
using System.Text;

namespace Odev
{
    class MusteriManager
    {

        public void Add(Musteri musteri)
        {
            Console.WriteLine("Musteri added." + " " + musteri.Name);
        }

        public void Delete(Musteri musteri)
        {
            Console.WriteLine("Musteri Deleted" + " " + musteri.Name);
        }
        public void List(Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Name + " " + musteri.Surname + " " + musteri.Price);
            }
        }
    }
}
