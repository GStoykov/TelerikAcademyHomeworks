using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

class DateTimePlusSixHoursAndHalf
{
    static void Main(string[] args)
    {
        DateTime date = DateTime.Now;
        DateTime resultDate = date.AddHours(6).AddMinutes(30);

        CultureInfo culture = new CultureInfo("bg-BG");

        Console.Write(resultDate + " ");
        Console.WriteLine(resultDate.ToString("dddd", culture));
        
        
    }
}
