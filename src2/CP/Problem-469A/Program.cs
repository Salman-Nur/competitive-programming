
int n = int.Parse(Console.ReadLine());
int[] X = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
X = X.Skip(1).ToArray();
int[] Y = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
Y = Y.Skip(1).ToArray();
int NoOfLevel = X.Concat(Y).Distinct().Count();

if (NoOfLevel == n)
{
    Console.WriteLine("I become the guy.");
}
else
{
    Console.WriteLine("Oh, my keyboard!");
}
