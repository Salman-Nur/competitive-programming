string str = Console.ReadLine();
int cnt = 1;
for (int i = 0; i < str.Length - 1; i++)
{
    if (str[i] == str[i + 1])
    {
        cnt++;
        if (cnt == 7)
        {
            Console.WriteLine("YES");
            break;
        }
    }
    else
    {
        cnt = 1;
    }
}
if (cnt != 7)
{
    Console.WriteLine("NO");
}
