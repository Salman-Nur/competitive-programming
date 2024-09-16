
internal class Program
{
    private static void Main(string[] args)
    {
        Solution solution = new Solution();
        string str = "Hello how are you Contestant";
        int k = 4;
        str = solution.TruncateSentence(str, k);
        Console.WriteLine(str);
    }
}

public class Solution
{
    public string TruncateSentence(string s, int k)
    {
        //string result = string.Empty;
        //string[] str = s.Split(' ');

        //for (int i = 0; i < k; i++)
        //{
        //    result += str[i] + " ";
        //}
        //result = result.TrimEnd();
        //return result;

        return string.Join(" ", s.Split(" ").Take(k));
    }
}