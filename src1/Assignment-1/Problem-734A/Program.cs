int n = int.Parse(Console.ReadLine());
string str = Console.ReadLine();
int a = 0, d = 0;
for (int i = 0; i < n; i++)
{
    if (str[i] == 'A')
    {
        a++;
    }
    else
    {
        d++;
    }
}
if (a > d)
{
    Console.WriteLine("Anton");
}
else if (d > a)
{
    Console.WriteLine("Danik");
}
else
{
    Console.WriteLine("Friendship");
}
