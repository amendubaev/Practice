﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Pow : ITwoArguments
    {
        public double Calculate(double firstField, double secondField)
        {
            return Math.Pow(firstField, secondField);
        }
    }
}
