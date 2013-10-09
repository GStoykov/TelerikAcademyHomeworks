using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._1_Print_N_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int.TryParse(Console.ReadLine(), out n);
            Console.WriteLine();
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
