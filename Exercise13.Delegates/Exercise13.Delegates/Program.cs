using System;

using Exercise13.Delegates.Starter;
using sln=Exercise13.Delegates.Solution;

namespace Exercise13.Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Build and Run, What happens?
            // 1. Change Download and add an Action<int> callback param
            // 3. Swap comments below and run
            // 4. Change code to use a local method and a lambda (see below)
            File.Download("http://movies.com/starwars.mp4");
            //File.Download("http://movies.com/starwars.mp4", ReportProgress);
        }
        static void ReportProgress(int progress)
        {
            Console.WriteLine($"{progress}% complete");
        }

        // Solutions below
        static void MainSolution_NamedMethod()
        {
            sln.File.Download("http://movies.com/starwars.mp4", ReportProgress);
        }

        static void MainSolution_LocalMethod()
        {
            string message = "% complete";
            void LocalReportProgress(int progress)
            {
                Console.WriteLine($"{progress}{message}");
            }
            sln.File.Download("http://movies.com/starwars.mp4", LocalReportProgress);
        }
        static void MainSolution_Lambda()
        {
            sln.File.Download("http://movies.com/starwars.mp4", p => Console.WriteLine($"{p}% complete") );
        }

    }
}
