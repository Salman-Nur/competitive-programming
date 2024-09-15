
public class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();

        var input = 121;

        var IsPalindrome = solution.IsPalindrome(input);
        Console.WriteLine(IsPalindrome);
    }
}


public class Solution
{
    public bool IsPalindrome(int x)
    {
        string str1 = x.ToString();
        var str2 = new string(str1.Reverse().ToArray());
        if (str1 == str2)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}