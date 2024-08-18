
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] numbers = Console.ReadLine().Split();
    int a = int.Parse(numbers[0]);
    int b = int.Parse(numbers[1]);

    if (a % b == 0)
    {
        Console.WriteLine(0);
    }
    else
    {
        Console.WriteLine(b - (a % b));
    }
}