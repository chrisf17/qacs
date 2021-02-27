using System;
namespace Exercise17.Exceptions.Solution
{
    public class Account
    {
        decimal balance;

        public decimal Balance { get => balance; private set => balance = value; }

        public virtual void Withdraw(decimal amount)
        {
            Balance -= amount;
        }
        public virtual void Deposit(decimal amount)
        {
            Balance -= amount;
        }

    }
}
