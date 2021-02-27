using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise5.Banking
{
    class Account
    {
        public decimal balance;
        public string sortCode;

        public void Withdraw(decimal amount)
        {
            balance -= amount;

        }

        public void Deposit(decimal amount)
        {
            balance += amount;

        }

        public override string ToString()
        {
            return $"SortCode:{sortCode}, Balance:{balance}";
        }

    }
}
