using System;
using System.Collections.Generic;
using System.Text;

namespace OOPExamples2.Manager
{
    class ArtisanLoanManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("The artisan loan payment plan has been calculated");
        }
    }
}
