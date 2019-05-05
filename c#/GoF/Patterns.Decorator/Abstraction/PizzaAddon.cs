namespace Patterns.Decorator.Abstraction
{
    public abstract class PizzaAddon : IPizza
    {
        public abstract decimal Cost();
        protected readonly IPizza _pizza;

        public PizzaAddon(IPizza pizza)
        {
            _pizza = pizza;
        }
    }
}
