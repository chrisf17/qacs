using System;
using SpellCheckerLib;

namespace Exercise11.Interfaces.Starter
{
    // Make ReportSummary implement ISpellCheckable
    // Implement the methods for ISpellCheckable
    // Lines should return new List<string>() {Title, Summary, Description,Results, Conclusion}
    // LineCount should return Lines.Count()
    public class ReportSummary
    {
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public string Results { get; set; }
        public string Conclusion { get; set; }

        
    }
}
