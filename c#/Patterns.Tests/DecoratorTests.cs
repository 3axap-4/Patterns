using NUnit.Framework;
using Patterns.Decorator.Concrete;

namespace Patterns.Tests
{
    [TestFixture]
    public class DecoratorTests
    {
        [Test]
        public void ShouldIncreaseCostWithAddons()
        {
            var basePizza = new NewYorkPizza();
            var pizzaWithOlives = new OlivesPizzaAddon(basePizza);
            var pizzaWithOlivesAndHam = new HamPizzaAddon(pizzaWithOlives);
            var pizzaWithOlivesHamAndSalami = new SalamiPizzaAddon(pizzaWithOlivesAndHam);

            Assert.AreEqual(14, pizzaWithOlivesHamAndSalami.Cost());
        }

        [Test]
        public void ShouldIncreaseCostWithAddonsAndDiscount()
        {
            var basePizza = new NewYorkPizza();
            var pizzaWithOlives = new OlivesPizzaAddon(basePizza);
            var pizzaWithOlivesAndHam = new HamPizzaAddon(pizzaWithOlives);
            var pizzaWithOlivesHamAndSalami = new SalamiPizzaAddon(pizzaWithOlivesAndHam);
            var pizzaWithAddonsAndDiscount = new DiscountPizzaAddon(pizzaWithOlivesHamAndSalami);

            Assert.AreEqual(13.65, pizzaWithAddonsAndDiscount.Cost());
        }
    }
}
