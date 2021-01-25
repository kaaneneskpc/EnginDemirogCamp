using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Interface;

namespace GameDemo.Entities
{
    class SummerCampaing : ICampaignService
    {
        public void CalcSale(Games game)
        {
            game.GamePrice -= game.GamePrice * (0.75);
        }

        public void SaleInfo(Games game)
        {
            Console.WriteLine("Discount Applied.New Price : " + game.GamePrice);
        }
    }
}
