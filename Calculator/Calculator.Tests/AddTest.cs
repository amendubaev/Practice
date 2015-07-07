using System;
using NUnit.Framework;

namespace Calculator.Tests
{
    [TestFixture]
    public class AddTest
    {
        [Test]
        public void CalculateTest()
        {
            var calculator = new Add();
            double  testResult = calculator.Calculate(5, 5);
            double realResult = 10;
            Assert.Equals(testResult,realResult);
        }
    }
}
