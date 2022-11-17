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
        var actual = solution.ConvertToTitle(1);

        // Assert
        actual.Should().Be("A");
    }
    
    [Fact]
    public void Test2()
    {
        // Arrange
        var solution = new Solution();

        // Act
        var actual = solution.ConvertToTitle(28);

        // Assert
        actual.Should().Be("AB");
    }
    
    [Fact]
    public void Test3()
    {
        // Arrange
        var solution = new Solution();

        // Act
        var actual = solution.ConvertToTitle(701);

        // Assert
        actual.Should().Be("ZY");
    }
    
    [Fact]
    public void Test4()
    {
        // Arrange
        var solution = new Solution();

        // Act
        var actual = solution.ConvertToTitle(52);

        // Assert
        actual.Should().Be("AZ");
    }
}