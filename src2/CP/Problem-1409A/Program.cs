
int t = int.Parse(Console.ReadLine());
while (t > 0)
{
    int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int a = inputs[0];
    int b = inputs[1];
    decimal c = 0;
    decimal d = 0;
    decimal e = Math.Abs(a - b);
    d = Math.Floor((e + 9) / 10);
    Console.WriteLine(d);
    t--;
}
