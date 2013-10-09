using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _2.MathMethodsPerformanceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch incrementWatch = new Stopwatch();
            incrementWatch.Start();
            Increment.IntNumber(1, 100);
            Increment.LongNumber(1L, 100L);
            Increment.FloatNumber(1F, 100F);
            Increment.DoubleNumber(1, 100);
            Increment.DecimalNumber(1M, 100M);
            incrementWatch.Stop();
            Console.WriteLine("Increment`s time is {0}",incrementWatch.Elapsed);

            Stopwatch subtractWatch = new Stopwatch();
            subtractWatch.Start();
            Subtract.IntNumber(1, 100, 5);
            Subtract.LongNumber(1L, 100L, 5L);
            Subtract.FloatNumber(1F, 100F, 5F);
            Subtract.DoubleNumber(1, 100, 5);
            Subtract.DecimalNumber(1M, 100M, 5M);
            subtractWatch.Stop();
            Console.WriteLine("Subtract`s time is {0}", subtractWatch.Elapsed);

            Stopwatch addWatch = new Stopwatch();
            addWatch.Start();
            Add.IntNumber(1, 100, 5);
            Add.LongNumber(1L, 100L, 5L);
            Add.FloatNumber(1F, 100F, 5F);
            Add.DoubleNumber(1, 100, 5);
            Add.DecimalNumber(1M, 100M, 5M);
            addWatch.Stop();
            Console.WriteLine("Adding`s time is {0}", addWatch.Elapsed);

            Stopwatch multiplyWatch = new Stopwatch();
            multiplyWatch.Start();
            Multiply.IntNumber(1, 100, 5);
            Multiply.LongNumber(1L, 100L, 5L);
            Multiply.FloatNumber(1F, 100F, 5F);
            Multiply.DoubleNumber(1, 100, 5);
            Multiply.DecimalNumber(1M, 100M, 5M);
            multiplyWatch.Stop();
            Console.WriteLine("Multiplying`s time is {0}", multiplyWatch.Elapsed);

            Stopwatch divideWatch = new Stopwatch();
            divideWatch.Start();
            Divide.IntNumber(1, 100, 5);
            Divide.LongNumber(1L, 100L, 5L);
            Divide.FloatNumber(1F, 100F, 5F);
            Divide.DoubleNumber(1, 100, 5);
            Divide.DecimalNumber(1M, 100M, 5M);
            divideWatch.Stop();
            Console.WriteLine("Dividing`s time is {0}", divideWatch.Elapsed);

        }
    }
}
