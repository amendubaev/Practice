using Calculator.TwoArg;
using NUnit.Framework;

namespace Calculator.Tests
{
    /// <summary>
    /// Test for subtract method
    /// Created 3 testcases
    /// </summary>
    [TestFixture]
    public class SubtractCalculationTest
    {
        [TestCase(32, 33, -1)]
        [TestCase(2, 4, -2)]
        [TestCase(32, 12, 20)]
        public void CalculateTest(double firstArgument, double secondArgument, double result)
        {
            var calculator = new Subtract();
            double testResult = calculator.Calculate(firstArgument, secondArgument);
            Assert.AreEqual(testResult,result);
        }
    }
}
