
int n = int.Parse(Console.ReadLine());
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int countMax = 0;
int countMin = n - 1;

while(arr[countMax] != arr.Max())
{
    countMax++;
}

while(arr[countMin] != arr.Min())
{
    countMin--;
}

int result = (countMax - 1) + (n - countMin);

if(countMax > countMin)
    Console.WriteLine(result - 1);
else
    Console.WriteLine(result);
