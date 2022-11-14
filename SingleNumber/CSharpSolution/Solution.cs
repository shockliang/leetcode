using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpSolution;

public class Solution
{
    public int SingleNumber(int[] nums)
    {
        var mapping = new Dictionary<int, int>();

        foreach (var num in nums)
        {
            if (mapping.ContainsKey(num))
            {
                mapping[num]++;
            }
            else
            {
                mapping.Add(num, 1);
            }
        }

        return mapping.FirstOrDefault(x => x.Value == 1).Key;
    }
}