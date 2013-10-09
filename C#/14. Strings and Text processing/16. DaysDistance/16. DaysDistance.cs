using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DaysDistance
{
    static void Main(string[] args)
    {
        string start = "20.02.2006";
        string end = "3.03.2006";

        DateTime startDate = DateTime.ParseExact(start, "d.MM.yyyy", CultureInfo.InvariantCulture);
        DateTime endDate = DateTime.ParseExact(end, "d.MM.yyyy", CultureInfo.InvariantCulture);
        
        Console.WriteLine("Distance: {0} days", (endDate - startDate).TotalDays);
    }
}   
