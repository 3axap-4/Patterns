using NUnit.Framework;
using Patterns.AbstractFactory.Concrete;
using Patterns.AbstractFactory.Concrete.Houses;
using Patterns.AbstractFactory.Concrete.Roofs;
using Patterns.AbstractFactory.Concrete.Walls;

namespace Patterns.Tests
{
    [TestFixture]
    public class AbstractFactoryTests
    {
        [Test]
        public void WoodFactoryReturnValidProducts()
        {
            var factory = new WoodHouseFactory();
            var house = factory.GetDefaultHouse();
            var wall = factory.GetWall();
            var roof = factory.GetRoof();

            Assert.IsTrue(house is WoodHouse);
            Assert.IsTrue(wall is WoodWall);
            Assert.IsTrue(roof is WoodHouseRoof);
        }
    }
}
