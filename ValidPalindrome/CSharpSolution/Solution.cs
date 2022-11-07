using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpSolution;

public class Solution
{
    public bool IsPalindrome(string s)
    {
        var palindrome = new string(s.ToLower().Where(x => (x <= 122 && x >= 97) || (x >= 48 && x <= 57)).ToArray());
        
        return palindrome == new string(palindrome.Reverse().ToArray());
    }
}