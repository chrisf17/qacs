using System;
using System.Collections.Generic;

namespace SpellCheckerLib
{
    public class SpellChecker
    {
        public static List<string> SpellCheck(ISpellCheckable doc)
        {
            List<string> spellCheckErrors = new List<string>();
            int count = 0;
            foreach(string line in doc.Lines)
            {
                string checkLine = line.ToLower();
                // Spell check rule
                if (checkLine.Contains("teh "))
                {
                    spellCheckErrors.Add($"Line {count}: teh->the");
                }
                count++;
            }
            return spellCheckErrors;
        }
    }
}
