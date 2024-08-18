string line = Console.ReadLine();
string[] arr = line.Split(' ');
int n = int.Parse(arr[0]);
int k = int.Parse(arr[1]);
for (int i = 1; i <= k; i++)
{
    if (n % 10 == 0)
    {
        n = n / 10;
    }
    else
    {
        n = n - 1;
    }
}
Console.WriteLine(n);