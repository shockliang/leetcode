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
        var actual = solution.ContainsDuplicate(new[] { 1, 2, 3, 1 });
        
        // Assert
        actual.Should().BeTrue();
    }
    
    [Fact]
    public void Test2()
    {
        // Arrange
        var solution = new Solution();
        
        // Act
        var actual = solution.ContainsDuplicate(new[] { 1, 2, 3, 4 });
        
        // Assert
        actual.Should().BeFalse();
    }
    
    [Fact]
    public void Test3()
    {
        // Arrange
        var solution = new Solution();
        
        // Act
        var actual = solution.ContainsDuplicate(new[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 });
        
        // Assert
        actual.Should().BeTrue();
    }
}