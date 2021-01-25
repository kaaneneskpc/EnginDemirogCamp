using System;

namespace OOPExamples2
{
    class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("File System has been Logged");
        }
    }
}
