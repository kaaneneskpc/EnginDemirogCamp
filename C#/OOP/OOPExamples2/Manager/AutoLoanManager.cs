using System;
using System.Collections.Generic;
using System.Text;

namespace OOPExamples2
{
    class AutoLoanManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("The car loan payment plan has been calculated.");
        }
    }
}
