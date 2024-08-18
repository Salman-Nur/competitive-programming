int t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
    int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
    Array.Sort(arr);
    if (arr[0] + arr[1] == arr[2])
        Console.WriteLine("YES");
    else
        Console.WriteLine("NO");
}
