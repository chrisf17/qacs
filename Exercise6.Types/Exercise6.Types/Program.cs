using System;

namespace Exercise6.Types
{
    struct Account
    {
        public string AccountType { get; set; }
        private decimal balance;

        public decimal Balance { get => balance;  internal set => balance = value; }

        public Account(string type, decimal balance)
        {
            AccountType = type;
            this.balance = balance;
        }
        public void Deposit(decimal amount)
        {
            Balance += amount;
        }
    }
    class Program
    {
        /*
         TODO:
         
            1. Look at and run the code. Why did you get the result you did?
            AccountProcessor Process call had no effect.
            2. Change Account definition (above) from struct to class and run again
            What happened? Why?
            3. Change AccountProcessor so that Process is a static method
            4. Change code in Main to use the new Process method
            5. Define an AccountType enum containing Current, Savings and Investment accounts
            6. Change account to use AccountType enum rather than string
          */
        static void Main(string[] args)
        {
            Account myAccount = new Account("Current", 0);

            myAccount.Deposit(100);

            AccountProcessor pc = new AccountProcessor();
            pc.Process(myAccount);

            Console.WriteLine($"Balance is {myAccount.Balance}");
        }

        //static void Main(string[] args)
        //{
        //    Account myAccount = new Account("Current", 0);

        //    myAccount.Deposit(100);

        //    AccountProcessor.Process(myAccount);

        //    Console.WriteLine($"Balance is {myAccount.Balance}");
        //}

    }
}
