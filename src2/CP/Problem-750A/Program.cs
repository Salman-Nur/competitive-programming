
string[] inputs = Console.ReadLine().Split();
int n = int.Parse(inputs[0]);
int k = int.Parse(inputs[1]);
int c = 240 - k;
int sum = 0;
int count = 0;
for (int i = 1; i <= n; i++)
{
    sum += i * 5;
    if (sum > c)
    {
        break;
    }
    else
    {
        count++;
    }
}
Console.WriteLine(count);
