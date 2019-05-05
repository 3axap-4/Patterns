using NUnit.Framework;
using Patterns.Singleton;

namespace Patterns.Tests
{
    [TestFixture]
    public class SingletonTests
    {
        [Test]
        public void ShouldBeOnlyOneInstance()
        {
            var instance1 = SingletonClass.GetInstance();
            var instance2 = SingletonClass.GetInstance();
       
            Assert.True(object.ReferenceEquals(instance1, instance2));
        }
    }
}
