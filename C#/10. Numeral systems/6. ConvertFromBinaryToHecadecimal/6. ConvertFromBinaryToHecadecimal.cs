using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.ConvertFromBinaryToHecadecimal
{
    class Program
    {
        static bool isBinaryNumberValid(string binNumber)
        {
            List<char> bit = new List<char>();

            for (int i = 0; i < binNumber.Length; i++)
            {
                bit.Add(binNumber[i]);
            }

            for (int i = 0; i < binNumber.Length; i++)
            {
                if (bit[i] != '0' && bit[i] != '1')
                {
                    Console.WriteLine("Invalid binary number.");
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a binary number: ");
            string binNumber = Console.ReadLine();
            if (isBinaryNumberValid(binNumber) == false)
            {
                return;
            }

            List<char> bit = new List<char>();
            for (int i = binNumber.Length - 1; i >= 0; i--)
            {
                bit.Add(binNumber[i]);
            }

            int decimalNumber = 0;

            for (int i = 0; i < bit.Count; i++)
            {
                int number = int.Parse(bit[i].ToString());
                decimalNumber += number * (1 << i);
            }

            List<string> hecaNumber = new List<string>();
            int remainder = 0;
            do
            {

                remainder = decimalNumber % 16;
                decimalNumber = decimalNumber / 16;
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

            } while (decimalNumber > 0);

            hecaNumber.Reverse();

            Console.Write("Hecadecimal number: ");
            foreach (var digit in hecaNumber)
            {
                Console.Write(digit);
            }
            Console.WriteLine();






        }
    }
}
