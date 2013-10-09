using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Numbers_not_divisible_by_3_and_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Enter n: ");
            int.TryParse(Console.ReadLine(), out n);
            for (int i = 1; i <= n; i++)
            {
                if (i % 21 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
