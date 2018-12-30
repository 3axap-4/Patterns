using Patterns.Decorator.Abstraction;

namespace Patterns.Decorator.Concrete
{
    public class SalamiPizzaAddon : PizzaAddon
    {
        public override decimal Cost()
        {
            return _pizza.Cost() + 2m;
        }

        public SalamiPizzaAddon(IPizza baseComponent)
           : base(baseComponent)
        {}
    }
}
