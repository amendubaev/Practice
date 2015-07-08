using NUnit.Framework;

namespace Calculator.Tests
{
    [TestFixture]
    public class PowCalculationTest
    {
        [TestCase(3, 2, 9)]
        [TestCase(2, 4, 16)]
        [TestCase(12, 2, 144)]
        [TestCase(16, 2, 256)]
        public void CalculateTest(double argument, double secondArgument, double result)
        {
            var calculator = new Pow();
            var testResult = calculator.Calculate(argument, secondArgument);
            Assert.AreEqual(testResult, result);
        }
    }

}
