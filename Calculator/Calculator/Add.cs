﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Add : IOperation
    {
        public double Calculate(double x, double y)
        {
            return (x + y);
        }
    }
}
