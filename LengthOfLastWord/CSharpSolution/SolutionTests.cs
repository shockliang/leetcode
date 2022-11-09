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
        var actual = solution.LengthOfLastWord("Hello World");
        
        // Assert
        actual.Should().Be(5);
    }
    
    [Fact]
    public void Test2()
    {
        // Arrange
        var solution = new Solution();
        
        // Act
        var actual = solution.LengthOfLastWord("   fly me   to   the moon  ");
        
        // Assert
        actual.Should().Be(4);
    }
    
    [Fact]
    public void Test3()
    {
        // Arrange
        var solution = new Solution();
        
        // Act
        var actual = solution.LengthOfLastWord("luffy is still joyboy");
        
        // Assert
        actual.Should().Be(6);
    }

}