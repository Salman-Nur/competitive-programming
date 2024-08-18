int n = int.Parse(Console.ReadLine());
string str = Console.ReadLine();
int cnt = 0, sum = 0;
for (int i = 0; i < n; i++)
{
    if (str[i] == 'x')
    {
        cnt++;
    }
    else
    {
        cnt = 0;
        continue;
    }
    if (cnt >= 3)
    {
        sum++;
    }
}
Console.WriteLine(sum);
