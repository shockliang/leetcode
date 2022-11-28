using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpSolution;

public class Solution
{
    public bool IsIsomorphic(string s, string t)
    {
        if (s.Length != t.Length) return false;
        
        var sMapping = new Dictionary<char, int>();
        var tMapping = new Dictionary<char, int>();
        var sIsomorphic = new StringBuilder();
        var tIsomorphic = new StringBuilder();
        
        for (var i = 0; i < s.Length; i++)
        {
            if (!sMapping.ContainsKey(s[i]))
            {
                sMapping[s[i]] = i;
                sIsomorphic.Append($"{i} ");
            }
            else
            {
                sIsomorphic.Append($"{sMapping[s[i]]} ");
            }
            
            if (!tMapping.ContainsKey(t[i]))
            {
                tMapping[t[i]] = i;
                tIsomorphic.Append($"{i} ");
            }
            else
            {
                tIsomorphic.Append($"{tMapping[t[i]]} ");
            }
            
        }

        return sIsomorphic.ToString() == tIsomorphic.ToString();
    }
}