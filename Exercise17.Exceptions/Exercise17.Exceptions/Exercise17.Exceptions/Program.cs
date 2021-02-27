using System;
using sln = Exercise17.Exceptions.Solution;
namespace Exercise17.Exceptions
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Look at code in Start
            Start();
            //Solution1();
            //Solution2();
            //Solution3();
        }
        static void Start()
        {
            Account acc = new CurrentAccount(500);

            // 1. Run and notice you get an exception. Take a look at CurrentAccount Withdraw to see why
            // 2. Make the call below safe (handle the exception - report the error don't crash)
            // 3. Rethrow the exception in the Exception block. What happens
            // 4. Add a finally block and notic it always runs even when you rethrow (see Solution2())
            // 5. Make the rethrow safe in Main (put a try catch around acc.Widthdraw(1000))
            // 6. Look at Solution3(). Its using custom Events

            acc.Withdraw(1000);

            Console.WriteLine($"Your balance is {acc.Balance}");


        }
        static void Solution1()
        {
            Account acc = new CurrentAccount(500);

            try
            {
                acc.Withdraw(1000);
            }
            catch(Exception e)
            {
                Console.WriteLine($"Error:{e.Message}");
            }
            Console.WriteLine($"Your balance is {acc.Balance}");


        }
        static void Solution2()
        {
            Account acc = new CurrentAccount(500);

            try
            {
                acc.Withdraw(1000);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error:{e.Message}");
                throw;
            }
            finally
            {
                Console.WriteLine("Finally Ran");
            }
            Console.WriteLine($"Your balance is {acc.Balance}");


        }
        static void Solution3()
        {
            sln.Account acc = new sln.CurrentAccount(500);

            try
            {
                acc.Withdraw(1000);
            }
            catch (sln.AccountOverdrawnException e)
            {
                Console.WriteLine($"Error:Account would go overdrawn. Balance is {e.Balance}, amount requested was {e.Amount}");
            }
            Console.WriteLine($"Your balance is {acc.Balance}");


        }

    }
}
