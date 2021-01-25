using GameDemo.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Manager
{
    class DataLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Data has been Logged");
        }
    }
}
