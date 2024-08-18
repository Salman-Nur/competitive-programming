int len = int.Parse(Console.ReadLine()!);

for (int i = 0; i < len; i++)
{
    int[] nums = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
    if (nums[0] + nums[1] >= 10 || nums[0] + nums[2] >= 10 || nums[1] + nums[2] >= 10)
    {
        Console.WriteLine("YES");
        continue;
    }
    Console.WriteLine("NO");
}
