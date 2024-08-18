int t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
    int temp = 0;
    int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
    int[] arr1 = { arr[0], arr[1] };
    int[] arr2 = { arr[2], arr[3] };
    int cnt = arr1.Min();
    if (cnt > arr2[0] && cnt > arr2[1])
    {
        temp++;
    }
    cnt = arr2.Min();
    if (cnt > arr1[0] && cnt > arr1[1])
    {
        temp++;
    }
    if (temp == 0)
        Console.WriteLine("YES");
    else
        Console.WriteLine("NO");
}
