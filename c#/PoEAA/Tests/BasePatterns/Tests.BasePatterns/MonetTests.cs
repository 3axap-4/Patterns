using PoEAA.Money;
using Xunit;

namespace Tests.BasePatterns
{
    public class MonetTests
    {
        [Fact]
        public void Equals_SameAmounts_Success()
        {
            //Arrange
            var money1 = new Money(25.2, Currencies.USD);
            var money2 = new Money(25.2, Currencies.USD);

            //Act
            //Assert
            Assert.True(money1.Equals(money2));
        }

        [Fact]
        public void Equals_DiffersAmounts_Success()
        {
            //Arrange
            var money1 = new Money(25.2, Currencies.USD);
            var money2 = new Money(2, Currencies.USD);

            //Act
            //Assert
            Assert.False(money1 == money2);
        }

        [Fact]
        public void Equals_DiffersCurrencies_SameAmounts_Success()
        {
            //Arrange
            var money1 = new Money(25.2, Currencies.USD);
            var money2 = new Money(25.2, Currencies.EUR);

            //Act
            //Assert
            Assert.False(money1 == money2);
        }
    }
}
