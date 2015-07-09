
using Calculator.ArraySort;
using NUnit.Framework;

namespace Calculator.Tests
{
    /// <summary>
    /// Test for Array Sort method
    /// Created 4 testcases with arrays
    /// </summary>
    [TestFixture]
    public class ArraySortTest
    {
        [TestCase(new[] {199.0, 3.0, 25.0, 4.0, 78.0, 5.0}, new[] {3.0, 4.0, 5.0, 25.0, 78.0, 199.0})]
        [TestCase(new[] {9.0, 8.0, 7.0, 6.0, 5.0, 4.0, 3.0, 2.0, 1.0}, new[] {1.0, 2.0, 3.0, 4.0, 5.0, 6.0, 7.0, 8.0, 9.0})]
        [TestCase(new[] {56.0, 110.0, 67.0, 1.0, 0.0}, new[] {0.0, 1.0, 56.0, 67.0, 110.0})]
        [TestCase(new[] {1.0, 8.0, 2.0, 3.0, 9.0, 42.0, 32.0, 16.0, 69.0, 50.0, 39.0, 4.0, 14.0, 5.0, 0.0, 89.0, 100.0, 13.0, 11.0, 17.0, 22.0, 28.0},
            new[] {0.0, 1.0, 2.0, 3.0, 4.0, 5.0, 8.0, 9.0, 11.0, 13.0, 14.0, 16.0, 17.0, 22.0, 28.0, 32.0, 39.0, 42.0, 50.0, 69.0, 89.0, 100.0})]

        public void SortTest(double[] array, double[] result)
        {
            var gnomeSort = new GnomeSort();
            var bubbleSort = new BubbleSort();
            double[] testGnomeResult = gnomeSort.Sort(array);
            double[] testBubbleResult = bubbleSort.Sort(array);
            Assert.AreEqual(testBubbleResult,result);
            Assert.AreEqual(testGnomeResult, result);
        }
    }
}
