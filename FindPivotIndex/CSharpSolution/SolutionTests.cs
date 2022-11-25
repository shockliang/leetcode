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
        var actual = solution.PivotIndex(new[] { 1, 7, 3, 6, 5, 6 });

        // Assert
        actual.Should().Be(3);
    }
    
    [Fact]
    public void Test2()
    {
        // Arrange
        var solution = new Solution();

        // Act
        var actual = solution.PivotIndex(new[] { 1, 2, 3 });

        // Assert
        actual.Should().Be(-1);
    }
        
    [Fact]
    public void Test3()
    {
        // Arrange
        var solution = new Solution();

        // Act
        var actual = solution.PivotIndex(new[] { 2,1,-1 });

        // Assert
        actual.Should().Be(0);
    }
}