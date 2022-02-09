using System;

namespace OOP3
{
    class SmsLoggerServer : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Sms Gönderildi");
        }
    }

}
