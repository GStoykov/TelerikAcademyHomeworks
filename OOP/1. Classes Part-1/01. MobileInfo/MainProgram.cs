// Define a class that holds information about a mobile phone device:
// model, manufacturer, price, owner, battery characteristics (model, hours idle and hours talk) and
// display characteristics (size and number of colors). Define 3 separate classes
// (class GSM holding instances of the classes Battery and Display).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

class MainProgram
{
    static void Main()
    {
        GSM newMobile = new GSM("Gakaxy III", "Samsung", 900,"Peter");
        //Console.WriteLine(newMobile.ToString());

        GSMTest gsmArray = new GSMTest();
        //foreach (var item in gsmArray.arrOfMobiles)
        //{
        //    Console.WriteLine(item);
        //    Console.WriteLine();
        //}

        GSMCallHistoryTest gsmCallHistory = new GSMCallHistoryTest();
        gsmCallHistory.PhoneCalls();
    }
}

