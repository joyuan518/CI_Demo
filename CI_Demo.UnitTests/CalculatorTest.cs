using NUnit.Framework;
using CI_Demo.Function;

namespace CI_Demo.UnitTests
{
    [TestFixture]
    public class CalculatorTest
    {
        [Test]
        public void CanAdd()
        {
            Assert.AreEqual(3, new Calculator().Add(1, 2));
        }

        [Test]
        public void CanSub()
        {
            Assert.AreEqual(3, new Calculator().Sub(6, 3));
        }

        [Test]
        public void CanMultiply()
        {
            Assert.AreEqual(9, new Calculator().Multiply(3, 3));
        }

        [Test]
        public void CanDivide()
        {
            Assert.AreEqual(3, new Calculator().Divide(9, 3));
        }
    }
}
