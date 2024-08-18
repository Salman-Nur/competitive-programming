
int n = int.Parse(Console.ReadLine());
int[] d = new int[100], a = new int[100];
int r = 0;

for (int i = 0; i < n; i++)
{
    int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    d[arr[0] - 1] += 1;
    a[arr[1] - 1] += 1;
}

for (int i = 0; i < d.Length; i++)
{
    r += d[i] * a[i];
}
Console.WriteLine(r);
