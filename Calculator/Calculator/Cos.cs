using System;
namespace Calculator
{
    public class Cos : IOneArgument
    {
        public double Calculate(double firstField)
        {
            return (Math.Cos(firstField));
        }
    }
}
