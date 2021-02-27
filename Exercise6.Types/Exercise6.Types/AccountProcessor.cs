using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise6.Types
{
    class AccountProcessor
    {
        public void Process(Account acc)
        {
            acc.Balance -= 1000;
        }
    }
}
