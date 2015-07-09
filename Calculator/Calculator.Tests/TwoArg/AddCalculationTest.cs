using Calculator.TwoArg;
using NUnit.Framework;

namespace Calculator.Tests.TwoArg
{
    /// <summary>
    /// Test for addition method
    /// Created 4 testcases without accuracy
    /// </summary>
    [TestFixture]
    public class AddCalculationTest
    {
        [TestCase(32,33,65)]
        [TestCase(2, 4, 6)]
        [TestCase(12, 32, 44)]
        [TestCase(3212, 6536, 9748)]
      
        public void CalculateTest(double firstArgument, double secondArgument, double result)
        {
            var calculator = new Add();
            double testResult = calculator.Calculate(firstArgument, secondArgument);
            Assert.AreEqual(testResult,result);
        }
    }
}
