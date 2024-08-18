string line = Console.ReadLine();
int cnt = 0;
for (int i = 0; i < line.Length; i++)
{
    if (line[i] == '4' || line[i] == '7')
    {
        cnt++;
    }
}
if (cnt == 4 || cnt == 7)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}