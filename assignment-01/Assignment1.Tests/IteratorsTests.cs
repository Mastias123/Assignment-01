using Assignment1;

namespace Assignment1.Tests;

public class IteratorsTests
{
    [Fact]
    public void FlattenList()
    {
        // Arrange
        List<List<int>> listOfLists = new List<List<int>>()
        {
            new List<int>() { 1, 2, 3 },
            new List<int>() { 4, 5 },
            new List<int>() { 6, 7, 8, 9 }
        };
        List<int> answer = new List<int>{ 1, 2, 3, 4, 5,  6, 7, 8, 9};
        // Act
        var flattenList = Iterators.Flatten(listOfLists);
        
        // Assert
        Assert.Equal(answer, flattenList);
        
    }
    [Fact]
    public void IteratorTestTDictionary()
    {
        // Dictionary<string, Dictionary<string, string>> listOfLists =
        //  new Dictionary<string, Dictionary<string, string>>()
        // {
            
        //     {"1", new Dictionary<string, string>() {{"bil", "hus" }}},
        //     {"2", new Dictionary<string, string>() {{"cykel", "skur"}}}
        // };
        // Dictionary<string, string> answer = new Dictionary<string, string>{{"bil", "hus" }, {"cykel", "skur"}};
        // // Act
        // var flattenList = Iterators.Flatten(listOfLists);
        
        // // Assert
        // Assert.Equal(answer, flattenList);
        
    }

    [Fact]
    public void FilterEvenNumber()
    {    
        // Arrange
        List<int> listOfNumbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9};
        List<int> answer = new List<int>{2, 4, 6, 8};
        static bool IsEven(int n) => n % 2 == 0;

        // Act
        var filteredList = Iterators.Filter(listOfNumbers, IsEven);

        // Assert
        Assert.Equal(answer, filteredList);
        
    }
    [Fact]
    public void Filter_Strings_Of_length_Greater_Then_Three()
    {
        // Arrange
        List<string> listOfStrings = new List<string>() {"This", "is", "a", "list", "of", "strings"};
        List<string> answer = new List<string>() {"This", "list", "strings"};

        // Act
        static bool IsThreeOrMoreChar(string s) => s.Length >= 3;
        var filteredListOfStrings = Iterators.Filter(listOfStrings, IsThreeOrMoreChar);
        
        // Assert
        Assert.Equal(answer, filteredListOfStrings);
    }
}