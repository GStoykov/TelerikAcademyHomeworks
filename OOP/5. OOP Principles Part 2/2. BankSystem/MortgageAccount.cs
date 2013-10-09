using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.BankSystem
{
    public class MortgageAccount : Account
    {
        public MortgageAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        // Methods
        public override decimal CalculateInterest(int numberOfMonths)
        {
            if (Customer == Customer.individual && numberOfMonths > 6)
            {
                return this.Balance * (numberOfMonths - 6);
            }
            else if (Customer == Customer.company)
            {
                if (numberOfMonths < 12)
                {
                    return numberOfMonths * this.InterestRate / 2;
                }
                else
                {
                    return this.Balance * (numberOfMonths - 6);
                }
            }
            else
            {
                return 0;
            }
        }
    }
}
