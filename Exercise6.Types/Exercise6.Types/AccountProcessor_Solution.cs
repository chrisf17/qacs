using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise6.Types.Solution
{
    class AccountProcessor
    {
        public static void Process(Account acc)
        {
            acc.Balance -= 1000;
        }
    }
}
