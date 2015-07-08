using System;

namespace Calculator
{
    public class Tg : IOneArgument
    {
        public double Calculate(double firstField)
        {
            return (Math.Tan(firstField));
        }
    }
}
