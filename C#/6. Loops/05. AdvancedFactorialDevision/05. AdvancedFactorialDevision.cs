using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.AdvancedFactorialDevision
{
    class Program
    {
        static void Main(string[] args)
        {
           // Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).
            int n, k;
            double result = 1;
            do
            {
                Console.Write("Enter n (N > 1) : ");
                int.TryParse(Console.ReadLine(), out n);
                Console.Write("Enter k (K > N) : ");
                int.TryParse(Console.ReadLine(), out k);
            } while (n > k || n < 1);
            Console.Write("N! * K! / (K - N)! = {0}! * {1}! / ({1} - {0})! = ", n, k);

            int diff = k - n;

            while (k > diff)
            {
                while (n > 1)
                {
                    result *= n;
                    n--;
                }
                result *= k;
                k--;
            }
            Console.WriteLine(result);
        }
    }
}
