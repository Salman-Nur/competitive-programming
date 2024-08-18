string line = Console.ReadLine();
int upper = 0, lower = 0;
for (int i = 0; i < line.Length; i++)
{
    if (line[i] >= 'A' && line[i] <= 'Z')
    {
        upper++;
    }
    else
    {
        lower++;
    }
}
if (upper > lower)
{
    Console.WriteLine(line.ToUpper());
}
else
{
    Console.WriteLine(line.ToLower());
}