using System;

namespace OOP3
{
    class FileLoggerServer : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya Loglandı");
        }
    }

}
