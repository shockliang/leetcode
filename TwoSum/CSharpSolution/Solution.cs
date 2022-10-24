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
            var complement = target - nums[i];
            if (numsDic.ContainsKey(complement))
            {
                return new[] { numsDic[complement], i };
            }

            numsDic.TryAdd(nums[i], i);
        }

        return null;
    }
}