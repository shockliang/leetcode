using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpSolution;

public class Solution
{
    public int HammingWeight(uint n)
    {
        var binary = Convert.ToString(n, 2);
        var sum = binary.Count(x => x == '1');
        return sum;
    }
}