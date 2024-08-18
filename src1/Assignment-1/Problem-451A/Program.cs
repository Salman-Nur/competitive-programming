int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);
int n = arr[0];
int m = arr[1];
int cnt = 0;
while (n*m > 0)
{
    cnt++;
    n--;
    m--;
}
if (cnt % 2 == 0)
    Console.WriteLine("Malvika");
else
    Console.WriteLine("Akshat");
