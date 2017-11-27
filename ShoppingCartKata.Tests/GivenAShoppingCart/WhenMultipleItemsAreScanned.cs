using System.Collections.Generic;
using NUnit.Framework;

namespace ShoppingCartKata.Tests.GivenAShoppingCart
{
    [TestFixture]
    public class WhenMultipleItemsAreScanned
    {
        private readonly int _result;

        public WhenMultipleItemsAreScanned()
        {
            var items = new Dictionary<string, int>
            {
                { "Apple", 25 },
                { "Orange", 35 },
                { "Plum", 15 }
            };
            var subject = new ShoppingCart(items);
            subject.Scan("Apple");
            subject.Scan("Plum");

            _result = subject.Total();
        }

        [Test]
        public void ThenTheTotalIsCalculatedCorrectly()
        {
            Assert.That(_result, Is.EqualTo(40));
        }
    }
}