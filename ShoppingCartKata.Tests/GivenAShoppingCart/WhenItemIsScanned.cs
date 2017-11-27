using System.Collections.Generic;
using NUnit.Framework;

namespace ShoppingCartKata.Tests.GivenAShoppingCart
{
    [TestFixture]
    public class WhenItemIsScanned
    {
        private ShoppingCart _subject;

        [SetUp]
        public void SetUp()
        {
            var items = new Dictionary<string, int>
            {
                { "Apple", 25 },
                { "Orange", 35 },
                { "Plum", 15 }
            };
            _subject = new ShoppingCart(items);
        }

        [TestCase("Apple", 25)]
        [TestCase("Orange", 35)]
        [TestCase("Plum", 15)]
        public void ThenTheTotalIsSetCorrectly(string item, int expectedTotal)
        {
            _subject.Scan(item);
            Assert.That(_subject.Total(), Is.EqualTo(expectedTotal));
        }
    }
}
