﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Voorbeeld_Delegates_2
{
    public class Calculation
    {
        public static double Add (double a , double b)
        {
            return a + b;
        }
        public static double Substract(double a, double b)
        {
            return a - b;
        }
        public static double Multiply(double a, double b)
        {
            return a * b;
        }
        public static double Divide(double a, double b)
        {
            return a / b;
        }
    }
}
