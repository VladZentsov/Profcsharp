﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorCore.Infrastructure
{
    public interface INumberConverter
    {
        double Convert(string value);
        string ConvertBack(double value);
    }
}
