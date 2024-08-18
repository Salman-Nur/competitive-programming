int t = int.Parse(Console.ReadLine());

while(t--  > 0)
{
    string[] s = Console.ReadLine().Split(' ');
    if (int.Parse(s[0]) + int.Parse(s[1]) == int.Parse(s[2]))
    {
        Console.WriteLine('+');
    }
    else { Console.WriteLine("-"); }
}
