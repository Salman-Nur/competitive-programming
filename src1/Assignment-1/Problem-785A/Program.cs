int n = int.Parse(Console.ReadLine());
int cnt = 0;
for (int i = 0; i < n; i++)
{
    string str = Console.ReadLine();
    if (str[0] == 'T') cnt += 4;
    else if (str[0] == 'C') cnt += 6;
    else if (str[0] == 'O') cnt += 8;
    else if (str[0] == 'D') cnt += 12;
    else cnt += 20;
}
Console.WriteLine(cnt);
