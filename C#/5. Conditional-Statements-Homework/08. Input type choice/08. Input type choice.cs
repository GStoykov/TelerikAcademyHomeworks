using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Input_type_choise
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a program that, depending on the user's choice inputs int, double or string variable.
             * If the variable is integer or double, increases it with 1. If the variable is string, appends "*" at its end.
             * The program must show the value of that variable as a console output. Use switch statement. */
            string choice;
            do
            {
                Console.Write("What type of value you want to input (int, double or string): ");
                choice = Console.ReadLine();
            } while (choice != "int" ^ choice != "double" ^ choice != "string");
            switch (choice)
            {
                case "int":
                    int intValue;
                    Console.Write("Enter integer number: ");
                    int.TryParse(Console.ReadLine(), out intValue);
                    Console.WriteLine("Result = {0}", (intValue + 1)); break;
                case "double":
                    double doubleValue;
                    Console.Write("Enter real number: ");
                    double.TryParse(Console.ReadLine(), out doubleValue);
                    Console.WriteLine("Result = {0}", (doubleValue + 1d)); break;
                default:
                    Console.Write("Enter string: ");
                    string stringValue = Console.ReadLine();
                    Console.WriteLine("Result is: " + stringValue + "*");
                    break;
            }
        }
    }
}
