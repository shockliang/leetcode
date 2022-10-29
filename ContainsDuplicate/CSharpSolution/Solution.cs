using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpSolution;

public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        try
        {
            var result = nums.ToDictionary(x => x, x => x);
            return false;
        }
        catch (Exception e)
        {
            return true;
        }
    }
}