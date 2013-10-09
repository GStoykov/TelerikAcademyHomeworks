using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.MathMethodsPerformanceTest
{
    class Increment
    {
        public static void IntNumber(int startNumber, int endValue)
        {
            for (int i = startNumber; i < endValue; i++) { }
        }

        public static void LongNumber(long startNumber, long endValue)
        {
            for (long i = startNumber; i < endValue; i++) { }
        }

        public static void FloatNumber(float startNumber, float endValue)
        {
            for (float i = startNumber; i < endValue; i++) { }
        }

        public static void DoubleNumber(double startNumber, double endValue)
        {
            for (double i = startNumber; i < endValue; i++) { }
        }

        public static void DecimalNumber(decimal startNumber, decimal endValue)
        {
            for (decimal i = startNumber; i < endValue; i++) { }
        }
    }
}
