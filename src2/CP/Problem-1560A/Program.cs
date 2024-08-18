
int t = int.Parse(Console.ReadLine());

while(t > 0)
{
    int k = int.Parse(Console.ReadLine());
    int c = 0;
    int res = 1;

    while (c < k)
    {
        if(res % 3 != 0 && res % 10 != 3)
        {
            c++;
        }
        res++;
    }

    Console.WriteLine(res - 1);
    t--;
}
