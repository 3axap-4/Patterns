
namespace Patterns.Strategy.Abstraction
{
    public interface IMessageSender
    {
        bool Send(string recipient, string message);
    }
}
