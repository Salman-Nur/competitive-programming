string line = Console.ReadLine();
int cnt = 0;
for (int i = 0; i < line.Length; i++)
{
    if (line[i] == 'H' || line[i] == 'Q' || line[i] == '9')
    {
        Console.WriteLine("YES");
        cnt = 1;
        break;
    }
}
if (cnt == 0)
{
    Console.WriteLine("NO");
}