using System;
using Patterns.Strategy.Abstraction;

namespace Patterns.Strategy.Concrete
{
    public class SmsSender : IMessageSender
    {
        public bool Send(string recipient, string message)
        {
            ///Logic for sending message via sms

            Console.WriteLine($"Message {message} sent via sms, to {recipient}");
            return true;
        }
    }
}
