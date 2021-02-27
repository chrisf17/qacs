using System;
namespace Exercise17.Exceptions
{
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
                throw new Exception("Insufficient Funds");
            }
        }
    }
}
