using System;
using System.CodeDom;
using NUnit.Framework;

namespace Calculator.Tests
{
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
        [ExpectedException(typeof (Exception))]
        public void OperationForLog()
        {
            Type resultType = OperationsFactory.CreateOperation("Log").GetType();
        }
    }
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
            Type resultType = OperationsFactory.CreateTrigonometriaOperation("Sec").GetType();
        }
    }
}
