int t = int.Parse(Console.ReadLine());

while(t-- > 0)
{
    int n = int.Parse(Console.ReadLine());
    int count = 0;
    int d = n % 10;
    while (n > 0)
    {
        count++;
        n /= 10;
    }
    int ans = (d - 1) * 10;
    for (int j = 1; j <= count; j++)
    {
        ans += j;
    }
    Console.WriteLine(ans);
}
