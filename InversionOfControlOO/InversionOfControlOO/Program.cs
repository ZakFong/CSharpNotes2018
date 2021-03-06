﻿using System;

namespace InversionOfControlOO
{
    interface IMessage
    {
        void Send();
    }
    class EmailService : IMessage
    {
        public void Send()
        {
            Console.WriteLine("EmailService Send Message");
        }
    }
    class SMSService : IMessage
    {
        public void Send()
        {
            Console.WriteLine("SMSService Send Message");
        }
    }
    class Factory
    {
        public static EmailService GetEmailService()
        {
            return new EmailService();
        }
        public static SMSService GetSMSService()
        {
            return new SMSService();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DependencyService();
            InversionDependencyService();

            Console.WriteLine("Press any key for continuing...");
            Console.ReadKey();

        }

        static void DependencyService()
        {
            EmailService fooEmailService;
            Console.WriteLine("相依於 EmailService 類別的做法");
            fooEmailService = new EmailService();
            fooEmailService.Send();
        }

        static void InversionDependencyService()
        {
            IMessage fooMessage;
            Console.WriteLine();
            Console.WriteLine("相依於 Factory 類別，就不需要相依於各訊息發送的具體實作類別");
            fooMessage = Factory.GetEmailService();
            fooMessage.Send();
            fooMessage = Factory.GetSMSService();
            fooMessage.Send();
        }
    }
}
