using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CSharpSolution;

public class Solution
{
    public int[] RunningSum(int[] nums)
    {
        if (nums.Length == 1) return nums;
        
        var current = nums[0];
        var values = new int [nums.Length];
        values[0] = current;
        for (var i = 1; i < nums.Length; i++)
        {
            current += nums[i];
            values[i] = current;
        }

        return values;
    }
}