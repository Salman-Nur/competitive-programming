
int t = int.Parse(Console.ReadLine());

for(int i = 0; i < t; i++)
{
    string[] s = Console.ReadLine().Split(' ');
    int x = int.Parse(s[0]);
    int y = int.Parse(s[1]);
    int n = int.Parse(s[2]);

    n = n - y;
    n = n / x;
    n = n * x;
    n = n + y;

    Console.WriteLine(n);
}
