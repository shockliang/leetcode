using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CSharpSolution;

public class Solution
{
    public uint ReverseBits(uint n)
    {
        uint value = 0;
        var pow = 31;
        while (n != 0)
        {
            var result = (n & 1) << pow;
            value += result;
            n >>= 1;
            pow--;
        }
        
        return value;
    }
    
    
}