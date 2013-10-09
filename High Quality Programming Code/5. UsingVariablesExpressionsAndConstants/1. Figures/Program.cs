using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Figure fig = new Figure(3, 2);
        fig = fig.Rotate(fig, 30);
        Console.WriteLine(fig.Width);
        Console.WriteLine(fig.Height);
        
    }
}
