using System;
using System.Collections.Generic;
using System.Text;

namespace OOPExamples2
{
    class NeedLoanManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Needing loan payment plan has been calculated.");
        }
    }
}
