int n = int.Parse(Console.ReadLine());
string str = Console.ReadLine();
str = str.ToLower();
if (str.Distinct().Count() == 26)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}
