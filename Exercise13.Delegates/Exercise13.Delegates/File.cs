using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Exercise13.Delegates.Starter
{
    class File
    {
        public static void Download(string path) //, Action<int> callback)
        {
            for (int progress = 0; progress <= 100; progress++)
            {
                
                Thread.Sleep(100);
                // 2. Invoke callback parameter and pass progress as argument (see solution)
                
            }
        }
    }
}
