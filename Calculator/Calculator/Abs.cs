using System;

namespace Calculator
{
    public class Abs : IOneArgument
    {
        public double Calculate(double firstField)
        {
            return (Math.Abs(firstField));
        }
    }
}
