using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        // Integer exception
        //InvalidRangeException<int> integerException = new InvalidRangeException<int>("Our of range exception", -100, 100);
        //int[] numbers = { 4,  32, -100, 100, 500};
        //for (int i = 0; i < numbers.Length; i++)
        //{
        //    if (numbers[i] < integerException.Start || numbers[i] > integerException.End)
        //    {
        //        throw integerException;
        //    }
        //    else
        //    {
        //        Console.WriteLine(numbers[i]);
        //    }
        //}

        // DateTime exception
        InvalidRangeException<DateTime> dateException = new InvalidRangeException<DateTime>
            ("Invalid date", new DateTime(1980, 1, 1), new DateTime(2013, 12, 31));
        DateTime[] dates = {
                               new DateTime(1990, 3, 5),
                               new DateTime(1999, 5, 21),
                               new DateTime(2013, 12, 30),
                               new DateTime(2014, 2, 2),
                               new DateTime(2000, 1, 1),
                           };
        for (int i = 0; i < dates.Length; i++)
        {
            if (dates[i].Year < dateException.Start.Year || dates[i].Year > dateException.End.Year)
            {
                throw dateException;
            }
            else
            {
                Console.WriteLine(dates[i]);
            }
        }
    }
}
