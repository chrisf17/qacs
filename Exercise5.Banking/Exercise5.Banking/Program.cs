using System;

namespace Exercise5.Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO:
            // 1. Make account fields private
            // 2. Convert account class to use properties
            // 3. Balance should only be changed via Withdraw and Deposit
            // 4. Sort Code should be read only 
            // 5. Add a constructor that allows the sortcode to be initialsed
            // 6. Experiment below to make sure the requirements are satisfied

            Account acc = new Account();

            acc.Deposit(50);

            Console.WriteLine(acc);
        }
    }
}
