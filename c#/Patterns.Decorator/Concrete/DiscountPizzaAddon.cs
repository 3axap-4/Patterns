using Patterns.Decorator.Abstraction;

namespace Patterns.Decorator.Concrete
{
    public class DiscountPizzaAddon : PizzaAddon
    {
        private decimal DiscountAmouint => 2.5m;

        public override decimal Cost()
        {
            return _pizza.Cost() - (_pizza.Cost() * DiscountAmouint / 100);
        }

        public DiscountPizzaAddon(IPizza baseComponent)
           : base(baseComponent)
        { }
    }
}
