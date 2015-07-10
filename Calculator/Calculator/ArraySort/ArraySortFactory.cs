using System;

namespace Calculator.ArraySort
{
    public class ArraySortFactory
    {
        /// <summary>
        /// Sorting factory
        /// </summary>
        /// <param name="operation">Sorting method</param>
        /// <returns>Selected method</returns>
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
