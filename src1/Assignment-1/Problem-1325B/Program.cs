int t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
    int n = int.Parse(Console.ReadLine());
    int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
    Console.WriteLine(arr.Distinct().Count());
}
