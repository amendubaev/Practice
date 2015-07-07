using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Pow : IOperation
    {
        public double Calculate(double argument, double log)
        {
            return Math.Pow(argument, log);
        }
    }
}
