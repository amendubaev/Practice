using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Sin : IOneArgument
    {
        public double Calculate(double firstField)
        {
            return Math.Sin(firstField);
        }
    }
}
