using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.BankSystem
{
    public class DepositAccount : Account
    {
        public DepositAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        // Methods
        public override decimal CalculateInterest(int numberOfMonths)
        {
            if (Balance >= 0 && Balance <= 1000)
            {
                return 0;
            }
            return InterestRate * numberOfMonths;
        }

        public void Withdraw(decimal sum)
        {
            Balance -= sum;
        }

    }
}
