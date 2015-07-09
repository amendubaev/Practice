namespace Calculator.ArraySort
{
    public class GnomeSort : ISorter
    {
        /// <summary>
        /// Gnome sort method
        /// </summary>
        /// <param name="array">
        /// Input array,sorting array by Gnome method
        /// </param>
        /// <returns>
        /// Output array
        /// </returns>
        public double[] Sort(double[] array)
        {
            double temp_value = 0;
            for (int i = 1; i < array.Length;)
            {
                if (array[i - 1] <= array[i])
                    i += 1;
                else
                {
                    temp_value = array[i - 1];
                    array[i - 1] = array[i];
                    array[i] = temp_value;
                    i -= 1;
                    if (i == 0)
                        i = 1;
                }
            }
            return array;
        }
    }
}
