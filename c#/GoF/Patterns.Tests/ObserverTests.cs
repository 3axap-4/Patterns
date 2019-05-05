using Moq;
using NUnit.Framework;
using Patterns.Observer.Abstraction;
using Patterns.Observer.Concrete;

namespace Patterns.Tests
{
    [TestFixture]
    public class ObserverTests
    {
        [Test]
        public void ShouldCallSubscribersUpdateMethodOnce()
        {
            var sensor = new TemperatureSensor();

            var screen1 = new Mock<IObserver>().Object;
            var screen2 = new Mock<IObserver>().Object;

            sensor.Add(screen1);
            sensor.Add(screen2);
  
            //Act
            sensor.Notify();

            // Assert
            Mock.Get(screen1).Verify(x =>
                x.Update(), Times.Once);

            // Assert
            Mock.Get(screen2).Verify(x =>
                x.Update(), Times.Once);
        }
    }
}
