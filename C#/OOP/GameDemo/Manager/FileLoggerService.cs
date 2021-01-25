using GameDemo.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Manager
{
    class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("File has been logged");
        }
    }
}
