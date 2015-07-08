using System;
using NUnit.Framework;

namespace Calculator.Tests
{
    [TestFixture]
    public class CtgCalculationTest
    {
        [TestCase(90, -0.50, 0.01)]
        public void CalculateTest(double argument, double result, double accuracy)
        {
            var calculator = new Ctg();
            double testResult = calculator.Calculate(argument);
            Assert.AreEqual(testResult,result, accuracy);
        }

        [Test]
        [ExpectedException(typeof(Exception))]
        public void CtgZero()
        {
            var calculator = new Ctg();
            calculator.Calculate(0);
        }
    }
}
