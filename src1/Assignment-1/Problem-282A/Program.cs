int n = int.Parse(Console.ReadLine());
int cnt = 0;
for (int i = 0; i < n; i++)
{
    string str = Console.ReadLine();
    if (str == "++X" || str == "X++")
    {
        cnt++;
    }
    else
    {
        cnt--;
    }
}
Console.WriteLine(cnt);
