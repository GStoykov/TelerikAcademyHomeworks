using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.WorkDays
{
    class Program
    {
        static void Main(string[] args)
        {
           // Write a method that calculates the number of workdays between today and given date, passed as parameter.
           // Consider that workdays are all days from Monday to Friday except a fixed list of public holidays
           // specified preliminary as array.

            Console.Write("Enter date in format yyyy.mm.dd : ");
            string date = Console.ReadLine();
            DateTime startDate = DateTime.Today;
            DateTime endDate = DateTime.Parse(date).Date;

            DateTime[] holidays = { new DateTime(2013, 01, 01),
                                    new DateTime(2013, 01, 30),
                                    new DateTime(2013, 03, 03),
                                    new DateTime(2013, 05, 06),
                                    new DateTime(2013, 06, 01),
                                    new DateTime(2013, 09, 15),
                                    new DateTime(2013, 12, 25),
                                    new DateTime(2013, 12, 31)  };

            int dayRange = 0;
            dayRange = Math.Abs((endDate - startDate).Days);
            if (startDate > endDate)
            { 
                startDate = endDate;
                endDate = DateTime.Today;
            }
            int workDaysCounter = 0;
            bool isHoliday = false;

            for (int i = 0; i < dayRange; i++)
            {
                startDate = startDate.AddDays(1);
                if (startDate.DayOfWeek != DayOfWeek.Saturday && startDate.DayOfWeek != DayOfWeek.Sunday)
                {
                    for (int j = 0; j < holidays.Length; j++)
                    {
                        if (startDate == holidays[j])
                        {
                            isHoliday = true;
                            break;
                        }
                    }
                    if (isHoliday)
                    {
                        isHoliday = false;
                        continue;
                    }
                    else
                    {
                        workDaysCounter++;
                    }
                }
                
            }
            Console.WriteLine("Workdays are: {0} ",workDaysCounter);
            
        }
    }
}
