using System;
using System.Collections.Generic;
using SpellCheckerLib;

namespace Exercise11.Interfaces
{
    public class TextDocument : ISpellCheckable
    {
        string[] lines;
        public TextDocument(string fileName)
        {
            lines = System.IO.File.ReadAllLines(fileName);
        }
        public IEnumerable<string> Lines
        {
            get
            {
                return lines;
            }
        }

        public int LineCount => lines.Length;
    }
}
