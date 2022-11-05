using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpSolution;

public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        var shortestStr = strs.MinBy(x => x.Length);
        var matchCount = 0;
        while (matchCount != strs.Length)
        {
            matchCount = 0;
            foreach (var str in strs)
            {
                if (str.StartsWith(shortestStr))
                {
                    matchCount++;
                }
            }

            if(matchCount < strs.Length)
                shortestStr = shortestStr.Remove(shortestStr.Length - 1);
        }


        return matchCount == strs.Length ? shortestStr : "";
    }
}