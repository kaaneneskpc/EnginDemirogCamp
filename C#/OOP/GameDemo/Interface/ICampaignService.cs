using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Interface
{
    interface ICampaignService
    {
        void CalcSale(Games game);

        void SaleInfo(Games game);

    }
}
