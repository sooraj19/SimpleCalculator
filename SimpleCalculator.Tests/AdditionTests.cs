using System;
using NUnit.Framework;

namespace SimpleCalculator.Tests
{
    [TestFixture]
    public class AdditionTests
    {
        [Test]
        public void AddIntegers()
        {
            var s = new Sum();
            Assert.AreEqual(5, s.Add(2, 3));
        }

        [Test]
        public void AddFloats()
        {
            var s = new Sum();
            Assert.AreEqual(5.0, s.Add(2.0f, 3.0f));
        }

    }
}
