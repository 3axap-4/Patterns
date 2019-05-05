using Patterns.Strategy.Abstraction;
using System;

namespace Patterns.Strategy.Concrete
{
    public class EmailSender : IMessageSender
    {
        public bool Send(string recipient, string message)
        {
            ///Logic for sending message via email

            Console.WriteLine($"Message {message} sent via email, to {recipient}");
            return true;
        }
    }
}
