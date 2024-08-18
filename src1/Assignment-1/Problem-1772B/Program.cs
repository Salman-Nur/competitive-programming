int t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
    string[] row1 = Console.ReadLine().Split(' ');
    int a = int.Parse(row1[0]);
    int b = int.Parse(row1[1]);
    string[] row2 = Console.ReadLine().Split(' ');
    int c = int.Parse(row2[0]);
    int d = int.Parse(row2[1]);
    if (a < b && c < d && a < c && b < d)
    {
        Console.WriteLine("YES");
    }
    else if (c < a && d < b && c < d && a < b)
    {
        Console.WriteLine("YES");
    }
    else if (d < c && b < a && d < b && c < a)
    {
        Console.WriteLine("YES");
    }
    else if (b < d && a < c && b < a && d < c)
    {
        Console.WriteLine("YES");
    }
    else
    {
        Console.WriteLine("NO");
    }
}