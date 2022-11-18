using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpSolution;

public class Solution
{
    public bool IsPowerOfTwo(int n)
    {
        if (n < 0) return false;
        var mapping = new Dictionary<int, int>();

        for (var i = 0; i < 31; i++)
        {
            var key = 1 << i;
            mapping[key] = i;
        }

        return mapping.ContainsKey(n);
    }
}