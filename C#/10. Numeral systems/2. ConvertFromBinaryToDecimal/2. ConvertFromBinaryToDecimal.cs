using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _2.ConvertFromBinaryToDecimal
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
            for (int i = binNumber.Length -1; i >= 0; i--)
            {
                bit.Add(binNumber[i]);
            }

            int decimalNumber = 0;

            for (int i = 0; i < bit.Count; i++)
            {
                int number = int.Parse(bit[i].ToString());
                decimalNumber += number * (1 << i);
            }
            Console.WriteLine("Decimal representation: {0}", decimalNumber);
          
        }

    }
}
