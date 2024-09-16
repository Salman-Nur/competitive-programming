internal class Program
{
    private static void Main(string[] args)
    {
        Solution sln = new();
        char[] s = { 'a', 'b', 'b', 'c', 'd' };
        sln.ReverseString(s);
    }
}

public class Solution
{
    public void ReverseString(char[] s)
    {
        //s = s.Reverse().ToArray();
        Array.Reverse(s);
    }
}