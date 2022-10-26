using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpSolution;

public class Solution
{
    public bool IsPalindrome(int x)
    {
        if (x is >= int.MaxValue or <= int.MinValue or < 0) return false;

        var num = x.ToString();
        var reverse = new string(num.Reverse().ToArray());

        return num == reverse;
    }
}