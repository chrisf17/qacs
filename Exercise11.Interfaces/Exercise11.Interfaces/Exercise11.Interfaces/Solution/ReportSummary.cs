using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using SpellCheckerLib;
namespace Exercise11.Interfaces.Solution
{
    // Make ReportSummary implement ISpellCheckable
    // Implement the methods for ISpellCheckable
    
    public class ReportSummary:ISpellCheckable
    {
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public string Results { get; set; }
        public string Conclusion { get; set; }

        public IEnumerable<string> Lines => new List<string>
        {
            Summary, Description, Results, Conclusion
        };

        public int LineCount => Lines.Count();
    }
}
