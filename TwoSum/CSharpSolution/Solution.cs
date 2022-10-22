using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpSolution;

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var numsDic = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; i++)
        {
            if(!numsDic.ContainsKey(nums[i]))
                numsDic.Add(nums[i], i);
        }
        
        for (var i = 0; i < nums.Length; i++)
        {
            var complement = target - nums[i];
            numsDic.TryGetValue(complement, out var val);
            if (numsDic.ContainsKey(complement) && val != i)
            {
                return new[] { i, val };
            }
        }

        return null;
    }
}