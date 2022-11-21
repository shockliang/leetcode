using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpSolution;

public class Solution
{
    public int TitleToNumber(string columnTitle)
    {
        const int max = 26;
        var mapping = new Dictionary<char, int>();
        for (var i = 0; i < max; i++)
        {
            mapping[Convert.ToChar(65 + i)] = i + 1;
        }

        var sum = 0;
        var pow= 0;
        for (var i = columnTitle.Length - 1; i >= 0; i--)
        {
            var value = mapping[columnTitle[i]] * Math.Pow(max, pow);

            sum += (int)value;
            pow++;
        }

        return sum;
    }
}