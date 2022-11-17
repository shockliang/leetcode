using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpSolution;

public class Solution
{
    public string ConvertToTitle(int columnNumber)
    {
        const int max = 26;
        var mapping = new Dictionary<int, char>();
        for (var i = 0; i < max; i++)
        {
            mapping.Add(i + 1, Convert.ToChar(65 + i));
        }

        var stack = new Stack<char>();
        var result = columnNumber;
        while (result >0)
        {

            var remainder = result % max == 0 ? max : result % max;
            result -= remainder;
            result /= max;
            stack.Push(mapping[remainder]);
        }
        
        var str = new string(stack.ToArray());
        return str;
    }
}