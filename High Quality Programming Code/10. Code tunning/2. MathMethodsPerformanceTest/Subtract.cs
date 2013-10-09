using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.MathMethodsPerformanceTest
{
    class Subtract
    {
        public static void IntNumber(int startNumber, int endValue, int subtrahend)
        {
            for (int i = startNumber; i > endValue; i -= subtrahend) { }
        }

        public static void LongNumber(long startNumber, long endValue, long subtrahend)
        {
            for (long i = startNumber; i > endValue; i -= subtrahend) { }
        }

        public static void FloatNumber(float startNumber, float endValue, float subtrahend)
        {
            for (float i = startNumber; i > endValue; i -= subtrahend) { }
        }

        public static void DoubleNumber(double startNumber, double endValue, double subtrahend)
        {
            for (double i = startNumber; i > endValue; i -= subtrahend) { }
        }

        public static void DecimalNumber(decimal startNumber, decimal endValue, decimal subtrahend)
        {
            for (decimal i = startNumber; i > endValue; i -= subtrahend) { }
        }
    }
}
