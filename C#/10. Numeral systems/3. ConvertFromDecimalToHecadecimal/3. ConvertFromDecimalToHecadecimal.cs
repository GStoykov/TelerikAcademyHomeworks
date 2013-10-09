using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.ConvertFromDecimalToHecadecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a decimal number: ");
            int number = int.Parse(Console.ReadLine());
            List<string> hecaNumber = new List<string>();

            int remainder = 0;
            do
            {

                remainder = number % 16;
                number = number / 16;
                if (remainder == 10)
                {
                    hecaNumber.Add("A");                    
                }
                if (remainder == 11)
                {
                    hecaNumber.Add("B");                    
                }
                if (remainder == 12)
                {
                    hecaNumber.Add("C");
                }
                if (remainder == 13)
                {
                    hecaNumber.Add("D");
                }
                if (remainder == 14)
                {
                    hecaNumber.Add("E");
                }
                if (remainder == 15)
                {
                    hecaNumber.Add("F");
                }
                else
                {
                    hecaNumber.Add(remainder.ToString());
                }

            } while (number > 0);

            hecaNumber.Reverse();

            Console.Write("Hecadecimal number: ");
            foreach (var bit in hecaNumber)
            {
                Console.Write(bit);
            }
            Console.WriteLine();
        }
    }
}
