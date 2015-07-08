using System;

namespace Calculator
{
    public class Pow : ITwoArguments
    {
        public double Calculate(double firstField, double secondField)
        {
            return Math.Pow(firstField, secondField);
        }
    }
}
