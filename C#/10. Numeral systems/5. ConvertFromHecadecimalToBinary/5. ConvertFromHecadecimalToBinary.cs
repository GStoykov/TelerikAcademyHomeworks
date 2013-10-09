using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.ConvertFromHecadecimalToBinary
{
    class Program
    {
        static List<int> FromHecaToDecimalListOfDigits(string hecaNumber)
        {
            List<int> character = new List<int>();
            for (int i = 0; i < hecaNumber.Length; i++)
            {
                switch (hecaNumber.ToCharArray()[i])
                {
                    case '0': character.Add(0); break;
                    case '1': character.Add(1); break;
                    case '2': character.Add(2); break;
                    case '3': character.Add(3); break;
                    case '4': character.Add(4); break;
                    case '5': character.Add(5); break;
                    case '6': character.Add(6); break;
                    case '7': character.Add(7); break;
                    case '8': character.Add(8); break;
                    case '9': character.Add(9); break;
                    case 'A':
                    case 'a': character.Add(10); break;
                    case 'B':
                    case 'b': character.Add(11); break;
                    case 'C':
                    case 'c': character.Add(12); break;
                    case 'D':
                    case 'd': character.Add(13); break;
                    case 'E':
                    case 'e': character.Add(14); break;
                    case 'F':
                    case 'f': character.Add(15); break;
                    default: break;
                }
            }
            return character;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a Hecademical number: ");
            string hecaNumber = Console.ReadLine();


            List<int> hecaDigits = FromHecaToDecimalListOfDigits(hecaNumber);

            int decimalNumber = 0;
            hecaDigits.Reverse();

            for (int i = 0; i < hecaDigits.Count; i++)
            {
                decimalNumber += hecaDigits[i] * (int)Math.Pow(16, i);
            }

            List<int> binNumber = new List<int>();
            int remainder = 0;
            do
            {

                remainder = decimalNumber % 2;
                decimalNumber = decimalNumber / 2;
                binNumber.Add(remainder);

            } while (decimalNumber > 0);

            binNumber.Reverse();

            Console.Write("Binary Number: ");
            foreach (var bit in binNumber)
            {
                Console.Write(bit);
            }
            Console.WriteLine();
            
        }
    }
}
