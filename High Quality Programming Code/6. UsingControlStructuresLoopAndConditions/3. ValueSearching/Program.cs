using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3 };
        int number = 0;
        bool numberFound = false;
        while(number < 100)
        {
            bool dividendOnTen = (number % 10 == 0);
            if (dividendOnTen)
            {
                numberFound = (numbers[number] == expectedValue);
                if (numberFound)
                {
                    number = 666;
                }
            }
            Console.WriteLine(numbers[number]);
            number++;
        }

        if (numberFound)
        {
            Console.WriteLine("Value Found");
        }

    }
}

