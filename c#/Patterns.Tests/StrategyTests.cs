using NUnit.Framework;
using Patterns.Strategy.Abstraction;
using Patterns.Strategy.Concrete;
using System;
using System.IO;

namespace Patterns.Tests
{
    [TestFixture]
    public class StrategyTests
    {
        [Test]
        public void ShouldUseEmailSender()
        {
            IMessageManager manager = new MessageManager();

            var consoleOut = "";
            using (var stringWriter = new StringWriter())
            {
                Console.SetOut(stringWriter);
                manager.InformUser(1, "", Strategy.Constant.InformBy.Email);
                consoleOut = stringWriter.ToString();
            }
                    
            Assert.IsTrue(consoleOut.ToLower().Contains("sent via email"));
        }

        [Test]
        public void ShouldUseSmsSender()
        {
            IMessageManager manager = new MessageManager();

            var consoleOut = "";
            using (var stringWriter = new StringWriter())
            {
                Console.SetOut(stringWriter);
                manager.InformUser(1, "", Strategy.Constant.InformBy.Sms);
                consoleOut = stringWriter.ToString();
            }

            Assert.IsTrue(consoleOut.ToLower().Contains("sent via sms"));
        }
    }
}
