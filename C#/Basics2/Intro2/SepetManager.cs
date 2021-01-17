using System;
using System.Collections.Generic;
using System.Text;

namespace Intro2
{
    class SepetManager
    {
        public void Add(Urun urun)
        {
            Console.WriteLine("Congrats . Ürün added to Sepet : " 
                + urun.Name +" "+"Ürün price :" 
                + urun.Price +" "+ "Urun Detail : "+" "
                + urun.Detail+" "+"Ürün Stock : "+" "
                + urun.Stock);
        }
        
    }
}
