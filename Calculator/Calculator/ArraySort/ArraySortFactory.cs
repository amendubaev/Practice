using System;

namespace Calculator.ArraySort
{
    public class ArraySortFactory
    {
        /// <summary>
        /// Array Sorting factory
        /// </summary>
        /// <param name="operation">
        /// Array Sorting method, Created switch with operations of 2 sort methods
        /// </param>
        /// <returns>
        /// Selected method
        /// </returns>
        public static ISorter CreateSort(string operation)
        {
            switch (operation)
            {
                case "GnomeSort":
                    return new GnomeSort();
                case "BubbleSort":
                    return new BubbleSort();
                default:
                    throw new Exception("Unknown operation");
            }
        }
    }
}
