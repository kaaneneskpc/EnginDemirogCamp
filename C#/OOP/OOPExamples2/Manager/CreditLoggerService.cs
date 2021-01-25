using System;
using System.Collections.Generic;
using System.Text;

namespace OOPExamples2.Manager
{
    class CreditLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Credit system has been logged.");
        }
    }
}
