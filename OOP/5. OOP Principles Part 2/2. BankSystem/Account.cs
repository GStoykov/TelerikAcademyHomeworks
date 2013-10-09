using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.BankSystem
{
    public abstract class Account : ICustomerable
    {
        private Customer customer;
        private decimal balance;
        private decimal interestRate;

        public Customer Customer
        {
            get { return this.customer; }
            set { this.customer = value; }
        }

        public decimal Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public decimal InterestRate
        {
            get { return this.interestRate; }
            set { this.interestRate = value; }
        }

        public Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.customer = customer;
            this.balance = balance;
            this.interestRate = interestRate;
        }

        // Methods
        public virtual decimal CalculateInterest(int numberOfMonths)
        {
            return this.InterestRate * numberOfMonths;
        }

        public void Deposit(decimal sum)
        {
            this.Balance += sum;
        }


    }
}
