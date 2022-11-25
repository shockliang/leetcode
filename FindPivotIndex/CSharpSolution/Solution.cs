using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CSharpSolution;

public class Solution
{
    public int PivotIndex(int[] nums)
    {
        var sumToLeft = new int[nums.Length];
        var sumToRight = new int[nums.Length];

        var current = nums[0];
        sumToRight[0] = current;
        for (var i = 1; i < nums.Length; i++)
        {
            current += nums[i];
            sumToRight[i] = current;
        }

        current = nums[^1];
        sumToLeft[^1] = current;
        var idx = 1;
        for (var i = nums.Length-2; i >=0; i--)
        {
            current += nums[i];
            sumToLeft[i] = current;
            idx++;
        }

        for (var i = 0; i < nums.Length; i++)
        {
            if (sumToRight[i] == sumToLeft[i])
                return i;
        }

        return -1;
    }
}