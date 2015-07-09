using System;
using Calculator.OneArg;
using Calculator.TwoArg;
using NUnit.Framework;

namespace Calculator.Tests
{
    /// <summary>
    /// Test for Operation Factory  method
    /// Created 5 testcases with two argument operations
    /// </summary>
    [TestFixture]
    public class OperationsFactoryTest
    {
        [TestCase(typeof(Add),"Add")]
        [TestCase(typeof(Divide), "Divide")]
        [TestCase(typeof(Subtract), "Subtract")]
        [TestCase(typeof(Multiply), "Multiply")]
        [TestCase(typeof(Pow), "Pow")]

        public void FactoryTest( Type type, string name)
        {
            Type resultType = OperationsFactory.CreateOperation(name).GetType();
            Assert.AreEqual(type, resultType);
        }

        [Test]
        [ExpectedException(typeof(Exception))]
        public void OperationForLog()
        {
            OperationsFactory.CreateOperation("Log").GetType();
        }
    }
    /// <summary>
    /// Test for one argument method
    /// Created 6 testcases with operations with 1 argument
    /// </summary>
    public class TrigonometriaOperationsFactoryTest
    {
        [TestCase(typeof(Sin), "Sin")]
        [TestCase(typeof(Cos), "Cos")]
        [TestCase(typeof(Ctg), "Ctg")]
        [TestCase(typeof(Tg), "Tg")]
        [TestCase(typeof(Abs), "Abs")]
        [TestCase(typeof(Sqrt), "Sqrt")]

        public void FactoryTest(Type type, string name)
        {
            Type resultType = OperationsFactory.CreateTrigonometriaOperation(name).GetType();
            Assert.AreEqual(type, resultType);
        }

        [Test]
        [ExpectedException(typeof(Exception))]
        public void OperationForLog()
        {
            OperationsFactory.CreateTrigonometriaOperation("Sec").GetType();
        }
    }
}
