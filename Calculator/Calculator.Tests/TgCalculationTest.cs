using NUnit.Framework;

namespace Calculator.Tests
{
    [TestFixture]
    public class AddTest
    {
        [TestCase(32,33,65)]
        [TestCase(2, 4, 6)]
        [TestCase(12, 32, 44)]
        [TestCase(3212, 6536, 9748)]
        public void CalculateTest(int firstArgument, int secondArgument,int result)
        {
            var calculator = new Add();
            double testResult = calculator.Calculate(firstArgument, secondArgument);
            Assert.AreEqual(testResult,result);
        }
    }
}
