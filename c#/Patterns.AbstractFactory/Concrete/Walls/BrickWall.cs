using Patterns.AbstractFactory.Abstraction;

namespace Patterns.AbstractFactory.Concrete.Walls
{
    public class BrickWall : IHouseWall
    {
        public override string ToString()
        {
            return "Brick wall";
        }
    }
}
