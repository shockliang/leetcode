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

        // Act
        var actual = solution.GetHint("1807", "7810");

        // Assert
        actual.Should().Be("1A3B");
    }
    
    [Fact]
    public void Test2()
    {
        // Arrange
        var solution = new Solution();

        // Act
        var actual = solution.GetHint("1123", "0111");

        // Assert
        actual.Should().Be("1A1B");
    }
    
    [Fact]
    public void Test3()
    {
        // Arrange
        var solution = new Solution();

        // Act
        var actual = solution.GetHint("1122", "2211");

        // Assert
        actual.Should().Be("0A4B");
    }  
    
    [Fact]
    public void Test4()
    {
        // Arrange
        var solution = new Solution();

        // Act
        var actual = solution.GetHint("1122", "0001");

        // Assert
        actual.Should().Be("0A1B");
    }
}