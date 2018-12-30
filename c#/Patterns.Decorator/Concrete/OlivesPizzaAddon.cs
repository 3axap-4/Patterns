using Patterns.Decorator.Abstraction;

namespace Patterns.Decorator.Concrete
{
    public class OlivesPizzaAddon : PizzaAddon
    {
        public override decimal Cost()
        {
            return _pizza.Cost() + 1m;
        }

        public OlivesPizzaAddon(IPizza baseComponent)
           : base(baseComponent)
        { }
    }
}
