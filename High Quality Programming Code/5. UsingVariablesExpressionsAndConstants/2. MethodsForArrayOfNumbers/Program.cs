using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        double[] numbers = {3.23, 42, 2.1, -32, 0, 1.0032, 7 };
        PrintValueStatistics(numbers);

    }

    // Statistics about average, maximum and minimum values in array of double type numbers 
    private static void PrintValueStatistics(double[] numbers)
    {
        double max = double.MinValue;
        double min = double.MaxValue;
        double sumOfElem = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
            sumOfElem += numbers[i];
        }
        double averageValue = sumOfElem / numbers.Length;
        Console.WriteLine("Average value in the array = {0}", averageValue);
        Console.WriteLine("Max value = {0}", max);
        Console.WriteLine("Min value = {0}", min);

    }
}
