using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Number_to_a_text
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that converts a number in the range [0...999] to a text corresponding to its English pronunciation
            string[] num20 = new string[20] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine",
            "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"};
            string[] decNum = new string[8] { "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            int num;
            // 22
            Console.Write("Enter a number in the range [0...999]: ");
            int.TryParse(Console.ReadLine(), out num);

            // 0 - 19
            if (num < 20)
            {
                Console.WriteLine("Number is {0}.", num20[num]);
            }

            // 20 - 99
            if ((num > 19) && (num < 100))
            {
                int unit, dec;
                dec = (num / 10) - 2;
                unit = num % 10;
                if (unit == 0)
                {
                    Console.WriteLine("Number is {0}.", decNum[dec]);
                }
                else
                {
                    Console.WriteLine("Number is {0} {1}.", decNum[dec], num20[unit]);
                }
            }

            // 100 - 999
            if ((num > 99) && (num < 1000))
            {
                int dec, hundread;
                hundread = num / 100;
                dec = num % 100;

                if (dec < 20)
                {
                    if (dec == 0)
                    {
                        Console.WriteLine("Number is {0} hundread.", num20[hundread]);
                    }
                    else
                    {
                        Console.WriteLine("Number is {0} hundread and {1}.", num20[hundread], num20[dec]);
                    }
                }
                if ((dec > 19) && (dec < 100))
                {
                    int unit;
                    unit = dec % 10;
                    dec = (dec / 10) - 2;
                    if (unit == 0)
                    {
                        Console.WriteLine("Number is {0} hundread and {1}.", num20[hundread], decNum[dec]);
                    }
                    else
                    {
                        Console.WriteLine("Number is {0} hundread and {1} {2}.", num20[hundread], decNum[dec], num20[unit]);
                    }
                }
            }
        }
    }
}
