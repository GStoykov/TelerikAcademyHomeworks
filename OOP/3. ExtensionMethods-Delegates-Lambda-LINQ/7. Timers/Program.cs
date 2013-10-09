using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        EachSecondMethod method = new EachSecondMethod(Timer.PrintSomething);
        method("Zdrasti", 2, 10);
    }
}
