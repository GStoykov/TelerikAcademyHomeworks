using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Prime_numbers_util_10mil
{
    class Program
    {
        static void Main(string[] args)
        {
            var start = DateTime.Now;
            int n = 10000000, counter = 0;
            bool[] arr = new bool[n];
            List<int> primes = new List<int>();

            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                if (arr[i] == false)
                {
                    
                    counter++;
                    for (int j = i * i; j < arr.Length; j += i)
                    {
                        arr[j] = true;
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == false)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
