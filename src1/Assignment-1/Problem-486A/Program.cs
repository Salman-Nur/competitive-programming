long n = long.Parse(Console.ReadLine());
if (n % 2 == 0)
{
    Console.WriteLine(n / 2);
}
else
{
    Console.WriteLine(-(n / 2 + 1));
}