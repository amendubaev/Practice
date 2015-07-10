using System;
using Calculator.TwoArg;
using NUnit.Framework;

namespace Calculator.Tests.TwoArg
{
    [TestFixture]
    public class DivideCalculationTest
    {
        [TestCase(9, 3, 3)]
        [TestCase(-100, -50, 2)]
        [TestCase(32, 2, 16)]
        public void CalculateTest(double firstArgument,double secondArgument, double result)
        {
            var calculator = new Divide();
            var testResult = calculator.Calculate(firstArgument, secondArgument);
            Assert.AreEqual(testResult, result);
        }

        [Test]
        [ExpectedException(typeof(Exception))]
        public void DivisionByZero()
        {
            var calculator = new Divide();
            calculator.Calculate(22,0);
        }
    }

}
