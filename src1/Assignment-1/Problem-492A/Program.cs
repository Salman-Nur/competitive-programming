int n = int.Parse(Console.ReadLine());
int cnt = 0, i = 1, sum = 0;
while (true)
{
    cnt += i;
    sum += cnt;
    if (sum == n)
    {
        Console.WriteLine(i);
        return 0;
    }
    else if (sum > n)
    {
        Console.WriteLine(i - 1);
        return 0;
    }
    else
        i++;
}
