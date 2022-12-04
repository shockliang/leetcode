using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpSolution;

public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public ListNode ReverseList(ListNode head)
    {
        ListNode previous = null;
        var current = head;
        while (current != null)
        {
            var temp = current.next;
            current.next = previous;
            previous = current;
            current = temp;
        }

        return previous;
    }
}