using Patterns.AbstractFactory.Abstraction;

namespace Patterns.AbstractFactory.Concrete.Roofs
{
    public class WoodHouseRoof: IHouseRoof
    {
        public override string ToString()
        {
            return "Wood house roof";
        }
    }
}
