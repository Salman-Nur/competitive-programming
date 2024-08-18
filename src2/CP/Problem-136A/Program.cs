
int n = int.Parse(Console.ReadLine());
int[] arr = new int[n];
int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

for (int i = 0; i < n; i++)
{
    arr[input[i] - 1] = i + 1;
}

foreach (var item in arr)
{
    Console.Write($"{item} ");
}