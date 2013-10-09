using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Bonus_score
{
    static void Main(string[] args)
    {
        int choice;
        Console.Write("Enter digit in range 1 - 9 : ");
        int.TryParse(Console.ReadLine(), out choice);
        switch (choice)
        {
            case 1:
            case 2:
            case 3: choice = choice * 10; break;

            case 4:
            case 5:
            case 6: choice = choice * 100; break;

            case 7:
            case 8:
            case 9: choice = choice * 1000; break;

            case 0: Console.WriteLine("Error !"); return;
            default: Console.WriteLine("Error !");
                return;
        }
        Console.WriteLine("Result: " + choice);
    }
}

