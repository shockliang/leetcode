using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpSolution;

public class Solution
{
    public bool IsValid(string s)
    {
        if (string.IsNullOrEmpty(s)) return false;
        if (string.IsNullOrWhiteSpace(s)) return false;
        if (s.Length == 1) return false;
        
        var stack = new Stack<char>();

        foreach (var c in s)
        {
            switch (c)
            {
                case '(':
                case '[':
                case '{':
                    stack.Push(c);
                    break;
                case ')':
                case ']':
                case '}':
                    if (stack.Count <= 0) return false;
                    var open = stack.Pop();
                    switch (open)
                    {
                        case '(' when c ==')':
                        case '[' when c ==']':
                        case '{' when c== '}':
                            continue;
                        default:
                            return false;
                    }

                default:
                    return false;
            }
        }

        return stack.Count == 0;
    }
}