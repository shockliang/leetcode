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
        var actual = solution.LongestCommonPrefix(new[] { "flower", "flow", "flight" });
        
        // Assert
        actual.Should().Be("fl");
    }
    
    [Fact]
    public void Test2()
    {
        // Arrange
        var solution = new Solution();
        
        // Act
        var actual = solution.LongestCommonPrefix(new[] { "dog", "racecar", "car" });
        
        // Assert
        actual.Should().Be("");
    }
    
    [Fact]
    public void Test3()
    {
        // Arrange
        var solution = new Solution();
        
        // Act
        var actual = solution.LongestCommonPrefix(new[] { "reflower", "flow", "flight" });
        
        // Assert
        actual.Should().Be("");
    }

}