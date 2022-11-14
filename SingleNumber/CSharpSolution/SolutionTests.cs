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

        // Act
        var actual = solution.SingleNumber(new[] { 2, 2, 1 });

        // Assert
        actual.Should().Be(1);
    }
    
    [Fact]
    public void Test2()
    {
        // Arrange
        var solution = new Solution();

        // Act
        var actual = solution.SingleNumber(new[] { 4,1,2,1,2 });

        // Assert
        actual.Should().Be(4);
    }
    
    [Fact]
    public void Test3()
    {
        // Arrange
        var solution = new Solution();

        // Act
        var actual = solution.SingleNumber(new[] { 1 });

        // Assert
        actual.Should().Be(1);
    }

}