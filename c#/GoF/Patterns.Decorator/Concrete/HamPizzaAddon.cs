using Patterns.Decorator.Abstraction;

namespace Patterns.Decorator.Concrete
{
    public class HamPizzaAddon : PizzaAddon
    {
        public override decimal Cost()
        {
            return _pizza.Cost() + 1m;
        }

        public HamPizzaAddon(IPizza baseComponent)
           : base(baseComponent)
        { }
    }
}
