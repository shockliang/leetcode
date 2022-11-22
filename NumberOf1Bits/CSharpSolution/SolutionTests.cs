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
        var actual = solution.HammingWeight(11);

        // Assert
        actual.Should().Be(3);
    }
    
    [Fact]
    public void Test2()
    {
        // Arrange
        var solution = new Solution();

        // Act
        var actual = solution.HammingWeight(128);

        // Assert
        actual.Should().Be(1);
    }
    
    [Fact]
    public void Test3()
    {
        // Arrange
        var solution = new Solution();

        // Act
        var actual = solution.HammingWeight(4294967293);

        // Assert
        actual.Should().Be(31);
    }

}