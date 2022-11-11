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
        var actual = solution.PlusOne(new[] { 1, 2, 3 });

        // Assert
        actual.Should().BeEquivalentTo(new[] { 1, 2, 4 });
    }

    [Fact]
    public void Test2()
    {
        // Arrange
        var solution = new Solution();

        // Act
        var actual = solution.PlusOne(new[] { 4, 3, 2, 1 });

        // Assert
        actual.Should().BeEquivalentTo(new[] { 4, 3, 2, 2 });
    }

    [Fact]
    public void Test3()
    {
        // Arrange
        var solution = new Solution();

        // Act
        var actual = solution.PlusOne(new[] { 9 });

        // Assert
        actual.Should().BeEquivalentTo(new[] { 1, 0 });
    }

    [Fact]
    public void Test4()
    {
        // Arrange
        var solution = new Solution();

        // Act
        var actual = solution.PlusOne(new[] { 9, 9, 9, 9, 9 });

        // Assert
        actual.Should().BeEquivalentTo(new[] { 1, 0, 0, 0, 0, 0 });
    }

    [Fact]
    public void Test5()
    {
        // Arrange
        var solution = new Solution();

        // Act
        var actual = solution.PlusOne(new[] { 3, 2, 9, 9, 9 });

        // Assert
        actual.Should().BeEquivalentTo(new[] { 3, 3, 0, 0, 0 });
    }
}