using NUnit.Framework;

namespace Calculator.Tests
{
    [TestFixture]
    public class CosCalculationTest
    {
        [TestCase(90, -0.45, 0.01)]
        [TestCase(100, 0.86, 0.01)]
        [TestCase(32, 0.83, 0.01)]
        [TestCase(180, -0.60, 0.01)]
        public void CalculateTest(double argument, double result, double accuracy)
        {
            var calculator = new Cos();
            var testResult = calculator.Calculate(argument);
            Assert.AreEqual(testResult, result, accuracy);
        }
    }

}
