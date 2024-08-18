int sum = 0;
int n = int.Parse(Console.ReadLine());
int[] drinks = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
for (int i = 0; i < drinks.Length; i++)
{
    sum = sum + drinks[i];
}
Console.WriteLine(drinks.Sum() / (double)n);