using Patterns.FactoryMethod.Abstraction;

namespace Patterns.FactoryMethod.Concrete
{
    public class SphereCreator : IShapeCreator
    {
        public IShape CreateShape()
        {
            return new Sphere();
        }
    }
}