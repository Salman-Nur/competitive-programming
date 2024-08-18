
var n = int.Parse(Console.ReadLine());
int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int min = inputs[0];
int c = 0;
int max = inputs[0];

for (int i = 1; i < n; i++)
{
    if (max < inputs[i])
    {
        max = inputs[i];
        c++;
    }
    else if (min > inputs[i])
    {
        min = inputs[i];
        c++;
    }
}
Console.WriteLine(c);
