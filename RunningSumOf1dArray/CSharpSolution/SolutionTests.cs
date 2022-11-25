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
        var actual = solution.RunningSum(new[] { 1, 2, 3, 4 });

        // Assert
        actual.Should().BeEquivalentTo(new[] { 1, 3, 6, 10 });
    }

    [Fact]
    public void Test2()
    {
        // Arrange
        var solution = new Solution();

        // Act
        var actual = solution.RunningSum(new[] { 1, 1, 1, 1, 1 });

        // Assert
        actual.Should().BeEquivalentTo(new[] { 1, 2, 3, 4, 5 });
    }

    [Fact]
    public void Test3()
    {
        // Arrange
        var solution = new Solution();

        // Act
        var actual = solution.RunningSum(new[] { 3,1,2,10,1 });

        // Assert
        actual.Should().BeEquivalentTo(new[] { 3, 4, 6, 16, 17 });
    }
}