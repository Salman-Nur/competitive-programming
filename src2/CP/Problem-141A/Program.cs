

string a = Console.ReadLine();
string b = Console.ReadLine();
string c = Console.ReadLine();
string d = string.Concat(a, b);

string e = string.Concat(c.OrderBy(y => y));
string f = string.Concat(d.OrderBy(y => y));

if (e == f)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}
