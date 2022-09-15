using System.Text.RegularExpressions;

namespace Assignment1;

public static class RegExpr
{
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
        string resolutionPattern = @"\D+";
        
        Regex rgx = new Regex(pattern);
        Regex resolutionRgx = new Regex(resolutionPattern);

        Dictionary<int, int> tempCollection = new Dictionary<int, int>();
        List<int> keys = new List<int>();
        List<int> values = new List<int>();


        foreach(string wholeLine in resolutions)
       {
            foreach(string word in rgx.Split(wholeLine))
            {
                var result = resolutionRgx.Split(word);

                for(int i = 0; i< result.Length ; i++)
                {
                    if(i%2 ==0)
                    {
                        int k = Int32.Parse(result[i]);
                        keys.Add(k);
                    }
                    else
                    {
                        int v = Int32.Parse(result[i]);
                        values.Add(v);
                    }
                }
            }
       }
       for(int i = 0; i< keys.Count ; i++)
       {
            tempCollection.Add(keys[i], values[i]);
            (int, int) tuple1 = (keys[i], values[i]);
            yield return tuple1;
       }
    } 

    public static IEnumerable<string> InnerText(string html, string tag)
    {
        string pattern = $@"(<{tag}[\w\s\d_()\-:\/"":,.=]*>)(?<inner>.*?)(</{tag}>)";
        foreach(Match match in Regex.Matches(html, pattern))
        {
            yield return match.Groups["inner"].Value;
        }
    } 
}
