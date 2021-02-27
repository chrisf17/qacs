using System;
using SpellCheckerLib;
// Comment out Starter and Uncomment Solution to see Solution
using Exercise11.Interfaces.Starter;
//using Exercise11.Interfaces.Solution;
namespace Exercise11.Interfaces
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Part1();
            Part2();
        }

        static void Part1()
        {
            TextDocument txt = new TextDocument("movies.txt");

            var errors = SpellChecker.SpellCheck(txt);
            Console.WriteLine($"Text Document has {errors.Count} Errors");

        }
        static void Part2()
        {
            // 1. Go into the ReportSummary and make it implement the ISpellCheckable interface
            ReportSummary txt = new ReportSummary()
            {
                Title = "My Report",
                Summary = "The report was a test and had no findings",
                Description = "This is a dummy report for teh test",
                Results = "There are no results in teh report",
                Conclusion = "No conclusions"

            };
            // 2. Once ReportSummary implements ISpellCheckable interface 
            //    it can be spellchecked
            //    Uncomment below lines when you are done or if you want to run solution
            //var errors = SpellChecker.SpellCheck(txt);
            //Console.WriteLine($"Report has {errors.Count} Errors");

        }

    }
}
