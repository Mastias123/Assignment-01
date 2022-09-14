using System.Text.RegularExpressions;

namespace Assignment1;

public static class RegExpr
{
    // public static void Main(string [] args)
    // {
    //     List<string> input = new List<string>(){"This", "is", "a", "test"};
        
    //     SplitLine(input);
    //     Console.WriteLine("Done");
    // }
    public static IEnumerable<string> SplitLine(IEnumerable<string> lines)
    {
       string pattern = @"\b\s+\b";
       Regex rgx = new Regex(pattern);

       foreach(string wholeLine in lines)
       {
            foreach(string word in rgx.Split(wholeLine))
            {
                
                yield return word;
                
            }
       }   
    }

    public static IEnumerable<(int width, int height)> Resolutions(IEnumerable<string> resolutions)
    {
        string pattern = @"\b\s+\b";
        Regex rgx = new Regex(pattern);
        foreach(string wholeLine in lines)
       {
            foreach(string word in rgx.Split(wholeLine))
            {
                
            }
       }

        return null;

    } 

    public static IEnumerable<string> InnerText(string html, string tag) => throw new NotImplementedException();
}
