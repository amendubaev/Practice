using System;

namespace Calculator
{
    public class Sqrt : IOneArgument
    {
        public double Calculate(double firstField)
        {
            return (Math.Sqrt(firstField));
        }
    }
}
