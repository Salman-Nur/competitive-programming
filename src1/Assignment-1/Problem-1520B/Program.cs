int t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
    long n = int.Parse(Console.ReadLine());
    int sum = 0;
    for (int i = 1; i < 10; i++)
    {
        long cnt = i;
        while (cnt <= n)
        {
            sum++;
            cnt = cnt * 10 + i;
        }

    }

    Console.WriteLine(sum);

}
