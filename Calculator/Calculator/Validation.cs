using System;
using System.Windows.Forms;

namespace Calculator
{ 
    /// <summary>
    /// Added class for Validation numbers
    /// </summary>
    public static class ValidationNumbers
    {
        public static double GetNumber(TextBox field)
        {
            double element;
            if (double.TryParse(field.Text, out element) == false)
            {
                throw new Exception("Unexpected symbol in input area!");
            }
            return Convert.ToDouble(field.Text);
        }
    }
    /// <summary>
    /// Added class for Validation Arrays
    /// </summary>
    public static class ValidationArrays
    {
        public static double[] GetArray(TextBox field)
        {
            string[] Split = field.Text.Split(new Char[] { ' ' });
            double[] mas = new double[Split.Length];
            for (int i = 0; i < Split.Length; i++)
            {
                if (double.TryParse(Split[i], out mas[i]) == false)
                {
                    throw new Exception("Unexpected symbol in input area!");
                }
            }
            return mas;
        }
    }
}
