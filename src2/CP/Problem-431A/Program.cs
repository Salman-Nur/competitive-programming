
string[] CaloriesStr = Console.ReadLine().Split();
int[] CaloriesInt = Array.ConvertAll(CaloriesStr, int.Parse);

string BlackBox = Console.ReadLine();
int sum = 0;

foreach (char c in BlackBox)
{
    sum += CaloriesInt[int.Parse(c.ToString()) - 1];
}

Console.WriteLine(sum);
