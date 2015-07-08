namespace Calculator
{
    internal class GnomeSort : ISorter
    {
        public double[] GnomeSort(double[] array)
        {
            for (int i = 1, temp_value; i < array.Length;)
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
        }
