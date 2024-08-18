int n = int.Parse(Console.ReadLine());
int cnt = 0;
string[] str = new string[n];
for (int i = 0; i < n; i++)
{
    str[i] = Console.ReadLine();
}
for (int j = 0; j < n - 1; j++)
{
    if (str[j] == str[j + 1])
    {
        continue;
    }
    else
    {
        cnt++;
    }
}
Console.WriteLine(cnt + 1);
