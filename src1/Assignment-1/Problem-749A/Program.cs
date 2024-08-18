int n = int.Parse(Console.ReadLine());
if (n % 2 == 0)
{
    Console.WriteLine(n / 2);
    for (int i = 2; i <= n; i += 2)
    {
        Console.Write("2 ");
    }
}
else
{
    Console.WriteLine(n / 2);
    n = n - 3;
    for (int i = 2; i <= n; i += 2)
    {
        Console.Write("2 ");
    }
    Console.Write("3");
}
