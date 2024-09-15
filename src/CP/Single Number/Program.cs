internal class Program
{
    private static void Main(string[] args)
    {
        Solution solution = new Solution();
        int[] numbers = { 1, 1, 3, 5, 5 };
        int num = solution.SingleNumber(numbers);
        Console.WriteLine(num);
    }
}


public class Solution
{
    public int SingleNumber(int[] nums)
    {
        int nonDuplicate = nums.GroupBy(x => x)
            .Where(g => g.Count() == 1)
            .Select(g => g.Key).First();

        return nonDuplicate;
    }
}