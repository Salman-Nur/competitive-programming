using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();

        string input = "Hello World";

        int length = solution.LengthOfLastWord(input);
        Console.WriteLine("Length of the last word: " + length);
    }
}


public class Solution
{
    public int LengthOfLastWord(string s)
    {
        s = s.TrimEnd();

        StringBuilder sb = new StringBuilder();

        if (s.Length == 0)
        {
            return 0;
        }
        else
        {
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == ' ')
                {
                    break;
                }
                else
                {
                    sb.Append(s[i]);
                }
            }
            return sb.Length;
        }
    }
}