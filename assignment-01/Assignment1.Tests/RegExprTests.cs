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
        List<string> lineOne = new List<string>(){"1920x1080", "1024x768, 800x600, 640x480"};

        //Dictionary<int, int> answer = new Dictionary<int, int>{};
        IEnumerable<KeyValuePair<int, int>> answer = new Dictionary<int, int>().AsEnumerable();
        (int, int)[] testTuple = 
        {
            (1920, 1080), (1024, 768),
            (800, 600) , (640, 480)
        };

        // Act
        var splitLine = RegExpr.Resolutions(lineOne);
        
        
        // Assert
        Assert.Equal(testTuple, splitLine);
    } 
    [Fact]
    public void catchInnerText()
    {
        // Arrange
        string lineOne = "<div><p>A <b>regular expression</b>, <b>regex</b> or <b>regexp</b> (sometimes called a <b>rational expression</b>) is, in <a href=\"https://en.wikipedia.org/wiki/Theoretical_computer_science\" title=\"Theoretical computer science\">theoretical computer science</a> and <a href=\"https://en.wikipedia.org/wiki/Formal_language\" title=\"Formal language\">formal language</a> theory, a sequence of <a href=\"https://en.wikipedia.org/wiki/Character_(computing)\" title=\"Character (computing)\">characters</a> that define a <i>search <a href=\"https://en.wikipedia.org/wiki/Pattern_matching\" title=\"Pattern matching\">pattern</a></i>. Usually this pattern is then used by <a href=\"https://en.wikipedia.org/wiki/String_searching_algorithm\" title=\"String searching algorithm\">string searching algorithms</a> for \"find\" or \"find and replace\" operations on <a href=\"https://en.wikipedia.org/wiki/String_(computer_science)\" title=\"String (computer science)\">strings</a>.</p></div>";
        string tag= "a";        
        List<string> answer = new List<string>{"theoretical computer science", "formal language", "characters", "pattern", "string searching algorithms", "strings"};

        // Act
        var splitLine = RegExpr.InnerText(lineOne, tag);

        // Assert
        Assert.Equal(answer, splitLine);
    }
}


