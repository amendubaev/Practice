using System;
using Calculator.OneArg;
using NUnit.Framework;

namespace Calculator.Tests.OneArg
{
    /// <summary>
    /// Test for sqrt method
    /// Created 4 testcases with accuracy 1.0
    /// </summary>
    [TestFixture]
    public class SqrtCalculationTest
    {
        [TestCase(4, 2, 1.0)]
        [TestCase(9, 3, 1.0)]
        [TestCase(16, 4, 1.0)]
        [TestCase(256, 16, 1.0)]
        public void CalculateTest(double argument, double result, double accuracy)
        {
            var calculator = new Sqrt();
            double testResult = calculator.Calculate(argument);
            Assert.AreEqual(testResult,result, accuracy);
        }

        [Test]
        [ExpectedException(typeof(Exception))]
        public void ZeroUnderTheSqrt()
        {
            var calculator = new Sqrt();
            calculator.Calculate(0);
        }
    }
}
