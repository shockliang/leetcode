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
        var actual = solution.RomanToInt("III");
        
        // Assert
        actual.Should().Be(3);
    }
    
    [Fact]
    public void Test2()
    {
        // Arrange
        var solution = new Solution();
        
        // Act
        var actual = solution.RomanToInt("LVIII");
        
        // Assert
        actual.Should().Be(58);
    }
    
    [Fact]
    public void Test3()
    {
        // Arrange
        var solution = new Solution();
        
        // Act
        var actual = solution.RomanToInt("MCMXCIV");
        
        // Assert
        actual.Should().Be(1994);
    }
    
    [Fact]
    public void Test4()
    {
        // Arrange
        var solution = new Solution();
        
        // Act
        var actual = solution.RomanToInt("XII");
        
        // Assert
        actual.Should().Be(12);
    }
    
    [Fact]
    public void Test5()
    {
        // Arrange
        var solution = new Solution();
        
        // Act
        var actual = solution.RomanToInt("XXVII");
        
        // Assert
        actual.Should().Be(27);
    }
    
    [Fact]
    public void Test6()
    {
        // Arrange
        var solution = new Solution();
        
        // Act
        var actual = solution.RomanToInt("IV");
        
        // Assert
        actual.Should().Be(4);
    }
}