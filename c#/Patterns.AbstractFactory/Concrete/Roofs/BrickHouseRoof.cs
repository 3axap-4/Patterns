using Patterns.AbstractFactory.Abstraction;

namespace Patterns.AbstractFactory.Concrete.Roofs
{
    public class BrickHouseRoof : IHouseRoof
    {
        public override string ToString()
        {
            return "Brick house roof";
        }
    }
}
