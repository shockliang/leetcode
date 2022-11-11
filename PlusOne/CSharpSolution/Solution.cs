using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpSolution;

public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        var length = digits.Length;
        var carry = 1;
        var stack = new Stack<int>();
        
        for (var i = length - 1; i >= 0; i--)
        {
            if (digits[i] + carry >= 10)
            {
                var current = (digits[i] + 1) % 10;
                stack.Push(current);
            }
            else
            {
                stack.Push(digits[i] + carry);
                carry = 0;
            }
        }
        
        if(carry > 0 ) stack.Push(1);
        
        return stack.ToArray();
    }
}