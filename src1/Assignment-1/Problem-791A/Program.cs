string line = Console.ReadLine();
string[] arr = line.Split(' ');
int a = int.Parse(arr[0]);
int b = int.Parse(arr[1]);
int cnt = 0;
while (a <= b)
{
    a = a * 3;
    b = b * 2;
    cnt++;
}
Console.WriteLine(cnt);