using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Greater_of_5_values
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] number = new double[5];
            string[] word = new string[5] { "first", "second", "third", "fourth", "fifth" };
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter {0} number: ", word[i]);
                double.TryParse(Console.ReadLine(), out number[i]);
            }
            for (int i = 0; i < 5; i++)
            {
                if (number[0] < number[i])
                {
                    double exValue;
                    exValue = number[0];
                    number[0] = number[i];
                    number[i] = exValue;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Biggest number is {0}", number[0]);
        }
    }
}
