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
        var actual = solution.IsPalindrome( "A man, a plan, a canal: Panama");
        
        // Assert
        actual.Should().BeTrue();
    }
    
    [Fact]
    public void Test2()
    {
        // Arrange
        var solution = new Solution();
        
        // Act
        var actual = solution.IsPalindrome("race a car");
        
        // Assert
        actual.Should().BeFalse();
    }
    
    [Fact]
    public void Test3()
    {
        // Arrange
        var solution = new Solution();
        
        // Act
        var actual = solution.IsPalindrome(" ");
        
        // Assert
        actual.Should().BeTrue();
    }
    
    [Fact]
    public void Test4()
    {
        // Arrange
        var solution = new Solution();
        
        // Act
        var actual = solution.IsPalindrome("ab@a");
        
        // Assert
        actual.Should().BeTrue();
    }
    
    [Fact]
    public void Test5()
    {
        // Arrange
        var solution = new Solution();
        
        // Act
        var actual = solution.IsPalindrome("0P");
        
        // Assert
        actual.Should().BeFalse();
    }
}