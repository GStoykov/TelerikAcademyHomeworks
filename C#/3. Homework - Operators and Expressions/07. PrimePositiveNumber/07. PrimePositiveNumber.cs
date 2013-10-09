using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PrimePositiveNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, remainder = 0;
            do
            {
            Console.Write("Enter a number between 2 and 100: ");
            int.TryParse(Console.ReadLine(), out n);
            }while(n < 2 ||  n > 100);

            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                remainder = n % i;
                if (remainder == 0)
                {
                    break;
                }
            }
            if (remainder != 0 || n < 4)
            {
                Console.WriteLine("Number is prime.");
            }
            else Console.WriteLine("Number is not prime.");
        }
    }
}
