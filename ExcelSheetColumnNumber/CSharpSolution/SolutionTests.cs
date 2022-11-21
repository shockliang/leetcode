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
        var actual = solution.TitleToNumber("A");

        // Assert
        actual.Should().Be(1);
    }
    
    [Fact]
    public void Test2()
    {
        // Arrange
        var solution = new Solution();

        // Act
        var actual = solution.TitleToNumber("AB");

        // Assert
        actual.Should().Be(28);
    }
    
    [Fact]
    public void Test3()
    {
        // Arrange
        var solution = new Solution();

        // Act
        var actual = solution.TitleToNumber("ZY");

        // Assert
        actual.Should().Be(701);
    }
    
    [Fact]
    public void Test4()
    {
        // Arrange
        var solution = new Solution();

        // Act
        var actual = solution.TitleToNumber("AZ");

        // Assert
        actual.Should().Be(52);
    }    
    
    [Fact]
    public void Test5()
    {
        // Arrange
        var solution = new Solution();

        // Act
        var actual = solution.TitleToNumber("FXSHRXW");

        // Assert
        actual.Should().Be(2147483647);
    }
}