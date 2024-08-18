int n = int.Parse(Console.ReadLine());
int cnt = 0;
for (int i = 0; i < n; i++)
{
    string str = Console.ReadLine();
    string[] parts = str.Split();
    //int a = int.Parse(parts[0]);
    //int b = int.Parse(parts[1]);
    //int c = int.Parse(parts[2]);
    int[] arr = Array.ConvertAll(parts, int.Parse);
    if (arr[0] + arr[1] + arr[2] > 1)
    {
        cnt++;
    }
}
Console.WriteLine(cnt);