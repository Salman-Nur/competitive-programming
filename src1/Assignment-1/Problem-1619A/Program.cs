int t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
    string str = Console.ReadLine();
    int n = str.Length;
    if (n % 2 != 0)
        Console.WriteLine("NO");
    else
    {
        n = n / 2;
        string str1 = str.Substring(0, n);
        string str2 = str.Substring(n);
        if (str1 == str2)
            Console.WriteLine("YES");
        else
            Console.WriteLine("NO");
    }
}
