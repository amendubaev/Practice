using System;

namespace Calculator
{
    public class Sin : IOneArgument
    {
        public double Calculate(double firstField)
        {
            return Math.Sin(firstField);
        }
    }
}
