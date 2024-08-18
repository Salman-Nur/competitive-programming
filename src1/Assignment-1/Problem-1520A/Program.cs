int t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
    int n = int.Parse(Console.ReadLine());
    string str = Console.ReadLine();
    int cnt = 1;
    for (int i = 0; i < n - 1; i++)
    {
        if (str[i] != str[i + 1] && str.LastIndexOf(str[i]) != i)
            cnt = 0;
        else
            continue;
    }
    if (cnt == 0)
        Console.WriteLine("NO");
    else
        Console.WriteLine("YES");

}
