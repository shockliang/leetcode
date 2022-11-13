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
        var actual = solution.AddBinary("11", "1");

        // Assert
        actual.Should().Be("100");
    }
    
    [Fact]
    public void Test2()
    {
        // Arrange
        var solution = new Solution();

        // Act
        var actual = solution.AddBinary("1010", "1011");

        // Assert
        actual.Should().Be("10101");
    }
    
    [Fact]
    public void Test3()
    {
        // Arrange
        var solution = new Solution();

        // Act
        var actual = solution.AddBinary("10101", "1011");

        // Assert
        actual.Should().Be("100000");
    }
    
    [Fact]
    public void Test4()
    {
        // Arrange
        var solution = new Solution();

        // Act
        var actual = solution.AddBinary("1", "0");

        // Assert
        actual.Should().Be("1");
    }    
    
    [Fact]
    public void Test5()
    {
        // Arrange
        var solution = new Solution();

        // Act
        var actual = solution.AddBinary("1", "1");

        // Assert
        actual.Should().Be("10");
    }
}