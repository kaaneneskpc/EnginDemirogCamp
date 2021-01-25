using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Interface;

namespace GameDemo.Entities
{
    class WinterCampaign : ICampaignService
    {
        public void CalcSale(Games game)
        {
            game.GamePrice -= game.GamePrice * (0.55);
        }

        public void SaleInfo(Games game)
        {
            Console.WriteLine("Discount Applied.New Price : " + game.GamePrice);
        }
    }
}
