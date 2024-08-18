int t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
    string[] str = Console.ReadLine().Split(' ');
    int n = int.Parse(str[0]);
    int x = int.Parse(str[1]);
    int cnt = 2;
    int FloorNo = 1;
    while (cnt < n)
    {
        cnt = cnt + x;
        FloorNo++;
    }
    Console.WriteLine(FloorNo);
}
