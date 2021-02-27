using System;
using System.Collections.Generic;

namespace SpellCheckerLib
{
    public interface ISpellCheckable
    {
        IEnumerable<string> Lines { get; }
        int LineCount { get; }
    }
}
