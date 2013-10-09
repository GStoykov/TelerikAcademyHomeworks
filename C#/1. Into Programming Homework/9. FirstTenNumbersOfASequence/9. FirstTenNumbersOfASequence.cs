using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _9.FirstTenNumbersOfASequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int possitiveNum = 2;
            int negativeNum = -3;
            for (int i = 0; i < 5; i++)
            {
                Console.Write(possitiveNum + " " + negativeNum + "  ");
                possitiveNum +=2;
                negativeNum -=2;
            }
            Console.WriteLine();
        }
    }
}
