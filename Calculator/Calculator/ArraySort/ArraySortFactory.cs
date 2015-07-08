using System;

namespace Calculator
{
    class ArraySortFactory
    {
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
