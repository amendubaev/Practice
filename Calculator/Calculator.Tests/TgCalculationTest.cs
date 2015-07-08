using System;
using NUnit.Framework;

namespace Calculator.Tests
{
    [TestFixture]
    public class TgCalculationTest
    {
        [TestCase(32, 0.66, 0.01)]
        [TestCase(0, 0, 0.01)]
        [TestCase(108, 2.46, 0.01)]
        public void CalculateTest(double argument, double result, double accuracy)
        {
            var calculator = new Tg();
            double testResult = calculator.Calculate(argument);
            Assert.AreEqual(testResult,result, accuracy);
        }

        [Test]
        [ExpectedException(typeof(Exception))]
        public void TanHalfPi()
        {
            var calculator = new Tg();
            calculator.Calculate(90);
        }
    }
}
