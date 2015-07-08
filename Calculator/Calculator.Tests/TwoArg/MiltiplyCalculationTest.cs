using NUnit.Framework;

namespace Calculator.Tests
{
    [TestFixture]
    public class MultiplyCalculationTest
    {
        [TestCase(3, 3, 9)]
        [TestCase(2, 4, 8)]
        [TestCase(12, 3, 36)]
        [TestCase(7, 8, 56)]
        public void CalculateTest(double firstArgument, double secondArgument, double result)
        {
            var calculator = new Multiply();
            double testResult = calculator.Calculate(firstArgument, secondArgument);
            Assert.AreEqual(testResult,result);
        }
    }
}
