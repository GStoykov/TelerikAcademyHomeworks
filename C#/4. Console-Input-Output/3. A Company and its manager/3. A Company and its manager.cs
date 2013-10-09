using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.A_Company_and_its_manager
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 3. A company has name, address, phone number, fax number, web site and manager.
            * The manager has first name, last name, age and a phone number. 
            * Write a program that reads the information about a company and its manager and prints them on the console. */
            string companyName, companyAddress, companyPhone, companyFax, companyWebSite, companyManager, managerFN, managerLN, managerPhone;
            byte managerAge;

            Console.Write("Enter company`s name: ");
            companyName = Console.ReadLine();
            Console.WriteLine("Company`s name is {0}.", companyName);

            Console.Write("Enter company`s address: ");
            companyAddress = Console.ReadLine();
            Console.WriteLine("Company`s address is {0}.", companyAddress);

            Console.Write("Enter company`s phone number: ");
            companyPhone = Console.ReadLine();
            Console.WriteLine("Company`s phone number is {0}.", companyPhone);

            Console.Write("Enter company`s fax: ");
            companyFax = Console.ReadLine();
            Console.WriteLine("Company`s fax is {0}.", companyFax);

            Console.Write("Enter company`s web site: ");
            companyWebSite = Console.ReadLine();
            Console.WriteLine("Company`s web site is {0}.", companyWebSite);

            Console.Write("Enter company`s manager: ");
            companyManager = Console.ReadLine();
            Console.WriteLine("Company`s manager is {0}.", companyManager);

            Console.Write("Enter manager`s first name: ");
            managerFN = Console.ReadLine();
            Console.WriteLine("Manager`s first name is {0}.", managerFN);

            Console.Write("Enter manager`s last name: ");
            managerLN = Console.ReadLine();
            Console.WriteLine("Manager`s last name is {0}.", managerLN);

            Console.Write("Enter manager`s age: ");
            byte.TryParse(Console.ReadLine(), out managerAge);
            Console.WriteLine("Manager`s age is {0}.", managerFN);

            Console.Write("Enter manager`s phone number: ");
            managerPhone = Console.ReadLine();
            Console.WriteLine("Manager`s phone number is {0}.", managerPhone);
        }
    }
}
