using System;
using NUnit.Framework;

namespace Calculator.Tests
{
    [TestFixture]
    public class ArraySortFactoryTest
    {
        [TestCase(typeof(GnomeSort), "GnomeSort")]
        [TestCase(typeof(BubbleSort), "BubbleSort")]

        public void FactoryTest( Type type, string name)
        {
            Type resultType =ArraySortFactory.CreateSort(name).GetType();
            Assert.AreEqual(type, resultType);
        }

        [Test]
        [ExpectedException(typeof(Exception))]
        public void OperationForLog()
        {
            Type resultType = ArraySortFactory.CreateSort("SelectSort").GetType();
        }
    }
}
