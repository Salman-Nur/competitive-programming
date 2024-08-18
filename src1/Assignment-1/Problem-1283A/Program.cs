int t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
    string[] str = Console.ReadLine().Split(' ');
    int hour = int.Parse(str[0]);
    int min = int.Parse(str[1]);
    int Hour = 24 - hour;
    Hour = Hour * 60;
    Console.WriteLine(Hour - min);
}