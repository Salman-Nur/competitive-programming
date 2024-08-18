string[] s = Console.ReadLine().Split(' ');
int n = int.Parse(s[0]);
int m = int.Parse(s[1]);
bool color = false;

for (int i = 0; i < n; i++)
{
    string row = Console.ReadLine();
    if (row.Contains('C') || row.Contains("M") || row.Contains('Y'))
    {
        color = true;
    }
}

if (color)
{
    Console.WriteLine("#Color");
}
else
{
    Console.WriteLine("#Black&White");
}
