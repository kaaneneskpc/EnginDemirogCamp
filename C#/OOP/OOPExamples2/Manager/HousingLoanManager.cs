using System;
using System.Collections.Generic;
using System.Text;

namespace OOPExamples2
{
    class HousingLoanManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Housing loan payment plan has been calculated.");
        }
    }
}
