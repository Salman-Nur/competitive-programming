var line = Console.ReadLine().Split(' ');
int n = int.Parse(line[0]);
int d = int.Parse(line[1]);
int cnt = 0, itr = 0, m = d, fcnt = 0;
while (d-- > 0)
{
    int temp = 0;
    string str = Console.ReadLine();
    itr++;
    for (int i = 0; i < n; i++)
    {
        if (str[i] == '0')
        {
            cnt++;
            if (cnt > fcnt)
                fcnt = cnt;
            break;
        }
        else
        {
            temp++;
            continue;
        }
    }
    if (temp == n)
        if (itr == m)
            break;
        else
            cnt = 0;
}
Console.WriteLine(fcnt);
