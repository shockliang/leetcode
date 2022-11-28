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
        var actual = solution.IsIsomorphic("egg", "add");

        // Assert
        actual.Should().BeTrue();
    }
    
    [Fact]
    public void Test2()
    {
        // Arrange
        var solution = new Solution();

        // Act
        var actual = solution.IsIsomorphic("foo", "bar");

        // Assert
        actual.Should().BeFalse();
    }
    
    [Fact]
    public void Test3()
    {
        // Arrange
        var solution = new Solution();

        // Act
        var actual = solution.IsIsomorphic("paper", "title");

        // Assert
        actual.Should().BeTrue();
    }
}