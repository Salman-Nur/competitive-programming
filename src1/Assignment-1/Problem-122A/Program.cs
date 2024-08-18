int n = int.Parse(Console.ReadLine());
int[] arr = { 4, 7, 44, 47, 74, 77, 444, 447, 474, 477, 747, 774, 777, 744 };
int cnt = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (n % arr[i] == 0)
    {
        cnt++;
    }
}
if (cnt == 0)
{
    Console.WriteLine("NO");
}
else
{
    Console.WriteLine("YES");
}
