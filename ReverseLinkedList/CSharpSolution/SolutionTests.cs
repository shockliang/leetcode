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
        var head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));

        // Act
        var actual = solution.ReverseList(head);

        // Assert
        var result = Produce(actual);
        result.Should().BeEquivalentTo(new List<int> { 5, 4, 3, 2, 1 });

    }
    
    [Fact]
    public void Test2()
    {
        // Arrange
        var solution = new Solution();
        var head = new ListNode(1, new ListNode(2));

        // Act
        var actual = solution.ReverseList(head);

        // Assert
        var result = Produce(actual);
        result.Should().BeEquivalentTo(new List<int> { 2, 1 });
    }
    
    [Fact]
    public void Test3()
    {
        // Arrange
        var solution = new Solution();

        // Act
        var actual = solution.ReverseList(null);

        // Assert
        var result = Produce(actual);
        result.Should().BeEmpty();
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