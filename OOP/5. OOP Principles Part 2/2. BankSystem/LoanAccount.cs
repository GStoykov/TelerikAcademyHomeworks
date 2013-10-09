using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BankSystem
{
    public class LoanAccount :Account
    {
        public LoanAccount(Customer customer, decimal balance, decimal interestRate) :base(customer, balance, interestRate)
        {
            
        }

        // Methods
        public override decimal CalculateInterest(int numberOfMonths)
        {
            if (Customer == Customer.individual && numberOfMonths > 3)
            {
                return this.Balance * (numberOfMonths - 3);
            }
            else if (Customer == Customer.company && numberOfMonths > 2)
            {
                return this.Balance * (numberOfMonths - 2);
            }
            else
            {
                return 0;
            }
        }


    }
}
