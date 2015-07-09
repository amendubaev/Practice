using System;
using Calculator.ArraySort;
using NUnit.Framework;

namespace Calculator.Tests
{
    /// <summary>
    /// Test for Array Sort Factory method
    /// Created 2 testcases with Gnome Sort method and Bubble Sort method
    /// </summary>
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
