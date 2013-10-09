﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.SinusSquareRootAndNaturalLogarithComparison
{
    public class NaturalLogTest
    {
        public static void FloatNumber(float startValue, float endValue, float step)
        {
            for (float i = startValue; i <= endValue; i = i + step)
            {
                Math.Log(i);
            }
        }

        public static void DoubleNumber(double startValue, double endValue, double step)
        {
            for (double i = startValue; i <= endValue; i = i + step)
            {
                Math.Log(i);
            }
        }

        public static void DecimalNumber(decimal startValue, decimal endValue, decimal step)
        {
            for (decimal i = startValue; i <= endValue; i = i + step)
            {
                Math.Log((double)i);
            }
        }
    }
}
