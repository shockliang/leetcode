using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpSolution;

public class Solution
{
    private Dictionary<char, int> romanMap = new()
    {
        ['I'] = 1,
        ['V'] = 5,
        ['X'] = 10,
        ['L'] = 50,
        ['C'] = 100,
        ['D'] = 500,
        ['M'] = 1000
    };

    public int RomanToInt(string s)
    {
        var value = 0;
        // var chars = s.ToUpper().ToArray();

        for (var i = s.Length - 1; i >= 0; i--)
        {
            if (i == s.Length - 1) value = romanMap[s[i]];

            if (i - 1 >= 0 && romanMap[s[i - 1]] < romanMap[s[i]])
            {
                value -= romanMap[s[i - 1]];
                continue;
            }

            if (i - 1 >= 0 && romanMap[s[i - 1]] >= romanMap[s[i]])
            {
                value += romanMap[s[i - 1]];
            }
        }

        return value;
    }
}