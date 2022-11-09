using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpSolution;

public class Solution
{
    public int LengthOfLastWord(string s)
    {
        var words = s.Split(' ').Where(x => !string.IsNullOrWhiteSpace(x)).ToList();
        return words.LastOrDefault().Length;
    }
}