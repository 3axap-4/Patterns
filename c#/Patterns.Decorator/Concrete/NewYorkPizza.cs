using Patterns.Decorator.Abstraction;

namespace Patterns.Decorator.Concrete
{
    public class NewYorkPizza : IPizza
    {
        public decimal Cost()
        {
            return 10m;
        }
    }
}
