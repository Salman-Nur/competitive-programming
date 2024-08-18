int n = int.Parse(Console.ReadLine());
string line = Console.ReadLine();
char ch = line[0];
int cnt = 0;
for (int i = 1; i < line.Length; i++)
{
    if (ch == line[i])
    {
        cnt++;
    }
    else
    {
        ch = line[i];
    }
}
Console.WriteLine(cnt);