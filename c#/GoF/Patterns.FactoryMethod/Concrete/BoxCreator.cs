using Patterns.FactoryMethod.Abstraction;

namespace Patterns.FactoryMethod.Concrete
{
    public class BoxCreator : IShapeCreator
    {
        public IShape CreateShape()
        {
            return new Box();
        }
    }
}
