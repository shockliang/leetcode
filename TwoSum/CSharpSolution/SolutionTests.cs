using FluentAssertions;
using Xunit;

namespace CSharpSolution;

public class SolutionTests
{
    [Fact]
    public void Test1()
    {
        // Arrange
        var nums = new[] { 2, 7, 11, 15 };
        var target = 9;
        var solution = new Solution();
        
        // Act
        var actual = solution.TwoSum(nums, target);
        
        // Assert
        actual.Should().Contain(new[] { 0, 1 });
    }
    
    [Fact]
    public void Test2()
    {
        // Arrange
        var nums = new[] { 3, 2, 4 };
        var target = 6;
        var solution = new Solution();
        
        // Act
        var actual = solution.TwoSum(nums, target);
        
        // Assert
        actual.Should().Contain(new[] { 1, 2 });
    }
    
    [Fact]
    public void Test3()
    {
        // Arrange
        var nums = new[] { 3, 3 };
        var target = 6;
        var solution = new Solution();
        
        // Act
        var actual = solution.TwoSum(nums, target);
        
        // Assert
        actual.Should().Contain(new[] { 0, 1 });
    }
    
    [Fact]
    public void Test4()
    {
        // Arrange
        var nums = new[] { 3, 2, 3 };
        var target = 6;
        var solution = new Solution();
        
        // Act
        var actual = solution.TwoSum(nums, target);
        
        // Assert
        actual.Should().Contain(new[] { 0, 2 });
    }
}