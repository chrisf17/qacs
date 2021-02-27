using System;
namespace Exercise17.Exceptions.Solution
{
    public class AccountOverdrawnException:ApplicationException
    {
        public decimal Balance { get; set; }
        public decimal Amount { get; set; }
    }

    public class CurrentAccount:Account
    {
        decimal overdraft;
        public CurrentAccount(decimal overdraft)
        {
            this.overdraft = overdraft;
        }

        public override void Withdraw(decimal amount)
        {
            if (amount <= Balance + overdraft)
            {
                base.Withdraw(amount);
            }
            else
            {
                throw new AccountOverdrawnException
                {
                    Balance = this.Balance,
                    Amount = amount
                };
            }
        }
    }
}
