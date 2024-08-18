
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int t = arr[1] * arr[2] / arr[^2] / arr[0];
int p = arr[3] * arr[4] / arr[0];
int s = arr[^3] / arr[^1] / arr[0];
Console.WriteLine(Math.Min(Math.Min(t, p), s));
