using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Calculating_factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that calculates N!/K! for given N and K (1<N<K).
            int n, k;
            double result = 1;
            do
            {
                Console.Write("Enter n (N > 1) : ");
                int.TryParse(Console.ReadLine(), out n);
                Console.Write("Enter k (K > N) : ");
                int.TryParse(Console.ReadLine(), out k);
            } while (n > k || n <= 0);

            for (int i = (n + 1); i <= k; i++)
            {
                result *= i;
            }
            result = 1 / result;
            Console.WriteLine("{0}! / {1}! = {2}", n, k, result);
        }
    }
}
