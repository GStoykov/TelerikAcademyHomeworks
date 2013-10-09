using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.MathMethodsPerformanceTest
{
    class Add
    {
        public static void IntNumber(int startNumber, int endValue, int addend)
        {
            for (int i = startNumber; i < endValue; i += addend) { }
        }

        public static void LongNumber(long startNumber, long endValue, long addend)
        {
            for (long i = startNumber; i < endValue; i += addend) { }
        }

        public static void FloatNumber(float startNumber, float endValue, float addend)
        {
            for (float i = startNumber; i < endValue; i += addend) { }
        }

        public static void DoubleNumber(double startNumber, double endValue, double addend)
        {
            for (double i = startNumber; i < endValue; i += addend) { }
        }

        public static void DecimalNumber(decimal startNumber, decimal endValue, decimal addend)
        {
            for (decimal i = startNumber; i < endValue; i += addend) { }
        }
    }
}
