int n = int.Parse(Console.ReadLine());
int sum = 0;
int[] arrfinal = new int[n];
for (int i = 0; i < n; i++)
{
    string line = Console.ReadLine();
    string[] arr = line.Split(' ');
    int exit = int.Parse(arr[0]);
    int enter = int.Parse(arr[1]);
    sum = (sum - exit) + enter;
    arrfinal[i] = sum;

}
Console.WriteLine(arrfinal.Max());
