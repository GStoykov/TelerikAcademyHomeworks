using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _3.SinusSquareRootAndNaturalLogarithComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch naturalLogWatch = new Stopwatch();
            naturalLogWatch.Start();
            NaturalLogTest.FloatNumber(1f, 100f, 5f);
            NaturalLogTest.DoubleNumber(1D, 100D, 5D);
            NaturalLogTest.DecimalNumber(1M, 100M, 5M);
            naturalLogWatch.Stop();
            Console.WriteLine("Natural logarith`s time is {0}", naturalLogWatch.Elapsed);

            Stopwatch sinusWatch = new Stopwatch();
            sinusWatch.Start();
            SinusTest.FloatNumber(1f, 100f, 5f);
            SinusTest.DoubleNumber(1D, 100D, 5D);
            SinusTest.DecimalNumber(1M, 100M, 5M);
            sinusWatch.Stop();
            Console.WriteLine("Sinus`s time is {0}", sinusWatch.Elapsed);

            Stopwatch squareRootWatch = new Stopwatch();
            squareRootWatch.Start();
            SquareRootTest.FloatNumber(1f, 100f, 5f);
            SquareRootTest.DoubleNumber(1D, 100D, 5D);
            SquareRootTest.DecimalNumber(1M, 100M, 5M);
            squareRootWatch.Stop();
            Console.WriteLine("Natural logarith`s time is {0}", squareRootWatch.Elapsed);

        }
    }
}
