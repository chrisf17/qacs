using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Exercise13.Delegates.Solution
{
    class File
    {
        public static void Download(string path, Action<int> callback)
        {
            for (int progress = 0; progress <= 100; progress++)
            {
                Thread.Sleep(100);
                callback.Invoke(progress);

            }
        }

    }
}
