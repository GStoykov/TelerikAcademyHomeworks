//7. Using delegates write a class Timer that has can execute certain method at each t seconds.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


public delegate void EachSecondMethod(string str, int seconds, int runTime);

public static class Timer
{
    public static void PrintSomething(string str, int seconds, int runTime)
    {
        DateTime start = DateTime.Now;
        DateTime stop = start.AddSeconds(runTime);
        while (start <= stop)
        {
            Console.WriteLine(str);
            Thread.Sleep(seconds * 1000);
            start = DateTime.Now;
        }
        
    }
}
