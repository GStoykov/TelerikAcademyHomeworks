using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Sum_with_accuracy_of_0._001
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...

            decimal sum = 1M, addend = 0M, i = 2M;
            bool positive = false;
            do
            {
                if (i % 2 == 0)
                {
                    addend = 1M / i;
                }
                else
                {
                    addend = 1M / i;
                    addend *= -1;
                }                
                sum = sum + addend;
                Console.WriteLine(sum);
                i++;
            } while (Math.Abs(addend) > 0.001M );
            
        }
    }
}
