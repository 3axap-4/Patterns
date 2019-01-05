using Patterns.AbstractFactory.Abstraction;

namespace Patterns.AbstractFactory.Concrete.Walls
{
    public class WoodWall: IHouseWall
    {
        public override string ToString()
        {
            return "Wood wall";
        }
    }
}
