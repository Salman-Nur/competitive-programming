int n = int.Parse(Console.ReadLine());
int x = 0, y = 0, z = 0;
for (int i = 0; i < n; i++)
{
    string str = Console.ReadLine();
    string[] arr = str.Split(' ');
    x = x + int.Parse(arr[0]);
    y = y + int.Parse(arr[1]);
    z = z + int.Parse(arr[2]);
}
if (x == 0 && y == 0 && z == 0)
    Console.WriteLine("YES");
else
    Console.WriteLine("NO");