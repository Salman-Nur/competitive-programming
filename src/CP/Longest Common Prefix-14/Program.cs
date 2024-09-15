
public class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();

        string[] input = { "abcd", "abc", "ab" };

        string shortest = solution.LongestCommonPrefix(input);
        Console.WriteLine(shortest);
    }
}


public class Solution
{
    public string LongestCommonPrefix(string[] ss)
    {
        string shortest = ss.OrderBy(s => s.Length).First();

        for (int i = 0; i < shortest.Length; i++)
        {
            if (ss.Select(s => s[i]).Distinct().Count() > 1)
                return shortest[..i];
        }

        return shortest;
    }
}

