using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.MathMethodsPerformanceTest
{
    class Divide
    {
        public static void IntNumber(int startValue, int endValue, int divisor)
        {
            for (int i = startValue; i >= endValue; i = i / divisor) { }
        }

        public static void LongNumber(long startValue, long endValue, long divisor)
        {
            for (long i = startValue; i >= endValue; i = i / divisor) { }
        }

        public static void FloatNumber(float startValue, float endValue, float divisor)
        {
            for (float i = startValue; i >= endValue; i = i / divisor) { }
        }

        public static void DoubleNumber(double startValue, double endValue, double divisor)
        {
            for (double i = startValue; i >= endValue; i = i / divisor) { }
        }

        public static void DecimalNumber(decimal startValue, decimal endValue, decimal divisor)
        {
            for (decimal i = startValue; i >= endValue; i = i / divisor) { }
        }
    }
}
