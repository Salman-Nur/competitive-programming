int t = int.Parse(Console.ReadLine());

while(t--  > 0)
{
    string[] input = Console.ReadLine().Split(" ");
    int x = int.Parse(input[0]);
    int y = int.Parse(input[1]);
    if (x < y)
    {
        int temp = x;
        x = y;
        y = temp;
    }
    int a = Math.Max(x, 2 * y);
    Console.WriteLine(a * a);
}
