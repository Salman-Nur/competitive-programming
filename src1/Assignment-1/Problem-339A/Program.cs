string[] str = Console.ReadLine().Split('+');
int[] arr = new int[str.Length];
for (int i = 0; i < str.Length; i++)
{
    arr[i] = int.Parse(str[i]);
}
Array.Sort(arr);
Console.WriteLine(String.Join("+", arr));

