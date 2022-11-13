using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpSolution;

public class Solution
{
    public string AddBinary(string a, string b)
    {
        var mapping = new Dictionary<char, byte>
        {
            ['0'] = 0,
            ['1'] = 1,
        };
        var queueA = new Queue<byte>();
        for (var i = a.Length - 1; i >= 0; i--)
        {
            queueA.Enqueue(mapping[a[i]]);
        }

        var queueB = new Queue<byte>();
        for (var i = b.Length - 1; i >= 0; i--)
        {
            queueB.Enqueue(mapping[b[i]]);
        }
        
        var maxQueue = a.Length >= b.Length ? queueA : queueB;
        var minQueue = a.Length >= b.Length ? queueB : queueA;
        var stack = new Stack<int>();
        var carry = 0;
        while (maxQueue.Count > 0)
        {
            int sum;
            int value;
            switch (maxQueue.Count)
            {
                case > 0 when minQueue.Count > 0:
                    sum = maxQueue.Dequeue() + minQueue.Dequeue() + carry;
                    carry = sum > 1 ? 1 : 0;
                    value = sum > 1 ? sum % 2 : sum;
                    stack.Push(value);
                    break;
                case > 0 when minQueue.Count == 0:
                    sum = maxQueue.Dequeue() + carry;
                    carry = sum > 1 ? 1 : 0;
                    value = sum > 1 ? sum % 2 : sum;
                    stack.Push(value);
                    break;
            }
        }

        if(carry > 0) stack.Push(carry);

        return string.Join("",stack.ToArray());
    }
}