using Patterns.Strategy.Constant;

namespace Patterns.Strategy.Abstraction
{
    public interface IMessageManager
    {
        void InformUser(int userId, string message, InformBy method);
    }
}
