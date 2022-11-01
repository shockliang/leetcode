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
        var actual = solution.IsValid("()");
        
        // Assert
        actual.Should().BeTrue();
    }
    
    [Fact]
    public void Test2()
    {
        // Arrange
        var solution = new Solution();
        
        // Act
        var actual = solution.IsValid("()[]{}");
        
        // Assert
        actual.Should().BeTrue();
    }
    
    [Fact]
    public void Test3()
    {
        // Arrange
        var solution = new Solution();
        
        // Act
        var actual = solution.IsValid("(]");
        
        // Assert
        actual.Should().BeFalse();
    }
    
    [Fact]
    public void Test4()
    {
        // Arrange
        var solution = new Solution();
        
        // Act
        var actual = solution.IsValid("(([{}]))");
        
        // Assert
        actual.Should().BeTrue();
    } 
    
    [Fact]
    public void Test5()
    {
        // Arrange
        var solution = new Solution();
        
        // Act
        var actual = solution.IsValid("([)]");
        
        // Assert
        actual.Should().BeFalse();
    }   
    
    [Fact]
    public void Test6()
    {
        // Arrange
        var solution = new Solution();
        
        // Act
        var actual = solution.IsValid("]");
        
        // Assert
        actual.Should().BeFalse();
    }
    
    [Fact]
    public void Test7()
    {
        // Arrange
        var solution = new Solution();
        
        // Act
        var actual = solution.IsValid(")(){}");
        
        // Assert
        actual.Should().BeFalse();
    }
}