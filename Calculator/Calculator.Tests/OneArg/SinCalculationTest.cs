using Calculator.OneArg;
using NUnit.Framework;

namespace Calculator.Tests.OneArg
{
    /// <summary>
    /// Test for sin method
    /// Created 4 testcases with accuracy 0.01
    /// </summary>
    [TestFixture]
    public class SinCalculationTest
    {
        [TestCase(90, 0.89, 0.01)]
        [TestCase(-100, 0.51, 0.01)]
        [TestCase(30, -0.98, 0.01)]
        public void CalculateTest(double argument, double result, double accuracy)
        {
            var calculator = new Sin();
            var testResult = calculator.Calculate(argument);
            Assert.AreEqual(testResult, result, accuracy);
        }
    }

}
