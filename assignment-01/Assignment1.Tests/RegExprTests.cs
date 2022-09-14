namespace Assignment1.Tests;

public class RegExprTests
{
    [Fact]
    public void splitLineOnSpaceAndLineShift()
    {
        // Arrange
        List<string> input = new List<string>(){"This is test\nThis is a new line"};
        List<string> answer = new List<string>{"This", "is", "test", "This", "is", "a", "new", "line"};
        // Act
        var splitLine = RegExpr.SplitLine(input);
        
        // Assert
        Assert.Equal(answer, splitLine);
        
    }   

    [Fact]
    public void splitOnResolutions()
    {
        // Arrange
        List<string> input = new List<string>(){"This is test\nThis is a new line"};
        List<string> answer = new List<string>{"This", "is", "test", "This", "is", "a", "new", "line"};
        // Act
        var splitLine = RegExpr.SplitLine(input);
        
        // Assert
        Assert.Equal(answer, splitLine);
        
    } 
}


