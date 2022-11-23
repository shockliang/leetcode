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
        var actual = solution.ReverseBits(43261596);

        // Assert
        actual.Should().Be(964176192);
    }    
    
    [Fact]
    public void Test2()
    {
        // Arrange
        var solution = new Solution();

        // Act
        var actual = solution.ReverseBits(4294967293);

        // Assert
        actual.Should().Be(3221225471);
    }
    
}