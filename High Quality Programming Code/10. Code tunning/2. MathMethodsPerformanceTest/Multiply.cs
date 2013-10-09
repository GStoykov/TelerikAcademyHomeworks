using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.MathMethodsPerformanceTest
{
    static class Multiply
    {
        public static void IntNumber(int startNumber, int endValue, int multiplier)
        {
            for (int i = startNumber; i < endValue; i *= multiplier) { }
        }

        public static void LongNumber(long startNumber, long endValue, long multiplier)
        {
            for (long i = startNumber; i < endValue; i *= multiplier) { }
        }

        public static void FloatNumber(float startNumber, float endValue, float multiplier)
        {
            for (float i = startNumber; i < endValue; i *= multiplier) { }
        }

        public static void DoubleNumber(double startNumber, double endValue, double multiplier)
        {
            for (double i = startNumber; i < endValue; i *= multiplier) { }
        }

        public static void DecimalNumber(decimal startNumber, decimal endValue, decimal multiplier)
        {
            for (decimal i = startNumber; i < endValue; i *= multiplier) { }
        }
    }
}