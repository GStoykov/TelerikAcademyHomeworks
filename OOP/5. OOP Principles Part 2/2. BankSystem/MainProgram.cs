using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BankSystem
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            // Deposit account testing
            DepositAccount georgi = new DepositAccount(Customer.individual, 500, 3);
            georgi.Deposit(300);
            Console.WriteLine("Georgi`s balance is: {0}", georgi.Balance);
            georgi.Withdraw(200);
            Console.WriteLine("Georgi`s balance after withdraw is: {0}", georgi.Balance);
            Console.WriteLine("Georgi has interest {0:0.00}" , georgi.CalculateInterest(10));
            
            // Loan account testing
            LoanAccount blizzard = new LoanAccount(Customer.company, 1000000, 5);
            blizzard.Deposit(5000000);
            Console.WriteLine("\nBlizzard`s balance is: {0}", blizzard.Balance);
            Console.WriteLine("Blizzard has interest {0:0.00}", blizzard.CalculateInterest(10));

        
            // Mortgage account testing 
            MortgageAccount misho = new MortgageAccount(Customer.individual, 10000, 7);
            misho.Deposit(500);
            Console.WriteLine("\nMisho`s balance is: {0}", misho.Balance);
            Console.WriteLine("Misho has interest {0:0.00}", misho.CalculateInterest(10));

        }
    }
}
