using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise5.Banking.Solution
{
    class Account
    {
        private decimal balance;
        private string sortCode;

        public decimal Balance { get => balance; private set => balance = value; }
        public string SortCode { get => sortCode; private set => sortCode = value; }

        public Account(string sortCode)
        {
            this.sortCode = sortCode;
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount;

        }

        public void Deposit(decimal amount)
        {
            Balance += amount;

        }

        public override string ToString()
        {
            return $"SortCode:{SortCode}, Balance:{Balance}";
        }

    }
}
