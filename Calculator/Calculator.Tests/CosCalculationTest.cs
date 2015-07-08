using NUnit.Framework;

namespace Calculator.Tests
{
    [TestFixture]
    public class AbsCalculationTest
    {
        [TestCase(-3, 3, 1.0)]
        [TestCase(-100, 100, 1.0)]
        [TestCase(32, 32, 1.0)]
        [TestCase(-4912, 4912, 1.0)]
        public void CalculateTest(int argument, int result, double accuracy)
        {
            var calculator = new Abs();
            var testResult = calculator.Calculate(argument);
            Assert.AreEqual(testResult, result, accuracy);
        }
    }

}
