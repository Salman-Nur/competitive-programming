
using Merge_Two_Sorted_Lists;

public class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();

        List<int> list1 = new List<int> { 1, 1, 4, 5 };
        List<int> list2 = new List<int> { 2, 2, 3 };

        ListNode shortest = solution.MergeTwoLists(list1, list2);
        Console.WriteLine(shortest);
    }
}


public class Solution
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        List<int> set = new List<int>();
        foreach (var item in list1)
        {
            set.Add(item);
        }
        foreach (var item in list2)
        {
            set.Add(item);
        }
        set.Sort();
        return set;
    }
}