
int[] set = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int counter = 0;

for(int i = 0; i < set[0]; i++)
{
    if(array[i] + set[1] <= 5)
    {
        counter++;
    }
}
Console.WriteLine(counter / 3);
