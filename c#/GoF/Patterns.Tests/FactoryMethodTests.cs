using NUnit.Framework;
using Patterns.FactoryMethod.Abstraction;
using Patterns.FactoryMethod.Concrete;

namespace Patterns.Tests
{
    [TestFixture]
    public class FactoryMethodTests
    {
        [Test]
        public void ShouldCreateObjectsCorrespondingType()
        {
            var creator = new BoxCreator();
            var shape = creator.CreateShape();

            Assert.True(shape is Box);
            Assert.True(shape is IShape);
        }
    }
}
