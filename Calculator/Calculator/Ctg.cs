using System;

namespace Calculator
{
    public class Ctg : IOneArgument
    {
        public double Calculate(double firstField)
        {
            return ((1/Math.Tan(firstField)));
        }
    }
}
