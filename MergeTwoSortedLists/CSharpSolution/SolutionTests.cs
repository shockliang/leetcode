using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace CSharpSolution;

public class SolutionTests
{
    [Fact]
    public void Test1()
    {
        // Arrange
        var solution = new Solution();
        var l1 = new ListNode(1, new ListNode(2, new ListNode(4)));
        var l2 = new ListNode(1, new ListNode(3, new ListNode(4)));

        // Act
        var actual = solution.MergeTwoLists(l1, l2);

        // Assert
        var result = Produce(actual);
        result.Should().BeEquivalentTo(new List<int> { 1, 1, 2, 3, 4, 4 });

    }
    
    [Fact]
    public void Test2()
    {
        // Arrange
        var solution = new Solution();
        var l1 = new ListNode();
        var l2 = new ListNode();

        // Act
        var actual = solution.MergeTwoLists(null, null);

        // Assert
        var result = Produce(actual);
        result.Should().BeEmpty();
    }
    
    [Fact]
    public void Test3()
    {
        // Arrange
        var solution = new Solution();
        
        var l2 = new ListNode(0);

        // Act
        var actual = solution.MergeTwoLists(null, l2);

        // Assert
        var result = Produce(actual);
        result.Should().BeEquivalentTo(new List<int> { 0 });
    }

    private static List<int> Produce(ListNode head)
    {
        var result = new List<int>();

        while (head != null)
        {
            result.Add(head.val);
            head = head.next;
        }

        return result;
    }
}