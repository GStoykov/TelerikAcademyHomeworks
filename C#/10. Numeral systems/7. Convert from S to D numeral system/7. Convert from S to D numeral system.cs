using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Convert_from_S_to_D_numeral_system
{
    class Program
    {

        static int ConvertToDecimal(string number, int numS)
        {
            int decimalNumber = 0;
            for (int i = 0; i < number.Length; i++)
            {
                int power = (int)Math.Pow(numS, number.Length - 1 - i);

                switch (number[i])
                {
                    case 'A': decimalNumber += 10 * power; break;
                    case 'B': decimalNumber += 11 * power; break;
                    case 'C': decimalNumber += 12 * power; break;
                    case 'D': decimalNumber += 13 * power; break;
                    case 'E': decimalNumber += 14 * power; break;
                    case 'F': decimalNumber += 15 * power; break;
                    default: decimalNumber += int.Parse(number[i].ToString()) * power; break;
                }
            }
            return decimalNumber;
        }

        static List<string> ConvertToSecondNumeralSystem(int decimalNumber, int numD)
        {
            // remainders are actual digits of final number
            List<string> remainders = new List<string>();

            while (decimalNumber > 0)
            {
                remainders.Add((decimalNumber % numD).ToString());
                decimalNumber /= numD;
            }

            for (int i = 0; i < remainders.Count; i++)
            {
                switch (remainders[i])
                {
                    case "10": remainders[i] = "A"; break;
                    case "11": remainders[i] = "B"; break;
                    case "12": remainders[i] = "C"; break;
                    case "13": remainders[i] = "D"; break;
                    case "14": remainders[i] = "E"; break;
                    case "15": remainders[i] = "F"; break;
                    default: break;
                }
            }
            remainders.Reverse();
            return remainders;
        }
   
        static void Print(List<string> finalNumber)
        {
            foreach (var digit in finalNumber)
            {
                Console.Write(digit);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            // Write a program to convert from any numeral system of given base s to any
            // other numeral system of base d (2 ≤ s, d ≤  16).
            Console.Write("Enter a number: ");
            string number = Console.ReadLine().ToUpper();
            
            // Enter both numeral system bases
            int numS = 0, numD = 0;
            while (numS < 2)
            {
                Console.Write("Enter first numeral system >= 2: ");
                numS = int.Parse(Console.ReadLine());
            }

            while ((numD > 16) || (numD <= numS))
            {
                Console.Write("Enter second numeral system: ");
                numD = int.Parse(Console.ReadLine());
            }

            int decimalNumber = ConvertToDecimal(number, numS);

            List<string> finalNumber = ConvertToSecondNumeralSystem(decimalNumber, numD);
            Console.Write("Number in numeral system with base {0} is: ", numD);
            Print(finalNumber);

        }


    }
}
