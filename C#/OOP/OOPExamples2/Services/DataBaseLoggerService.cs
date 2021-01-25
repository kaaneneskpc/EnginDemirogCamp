using System;
using System.Collections.Generic;
using System.Text;

namespace OOPExamples2
{
    class DataBaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Database has beeen Logged");
        }
    }
}
