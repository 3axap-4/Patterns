using System.Collections.Generic;
using Patterns.Strategy.Abstraction;
using Patterns.Strategy.Constant;

namespace Patterns.Strategy.Concrete
{
    public class MessageManager: IMessageManager
    {
        private readonly IDictionary<InformBy, IMessageSender> _senders;

        public MessageManager()
        {
            _senders = new Dictionary<InformBy, IMessageSender>
            {
                { InformBy.Email, new EmailSender() },
                { InformBy.Sms, new SmsSender() }
            };
        }

        public void InformUser(int userId, string message, InformBy method)
        {
            //Logic for retrieve user credentials by user Id

            _senders[method].Send($"address/phone of user {userId.ToString()}", message);
        }
    }
}
