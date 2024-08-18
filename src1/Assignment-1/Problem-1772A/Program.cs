int n = int.Parse(Console.ReadLine());
int sum = 0;
while (n-- > 0)
{
    string[] str = Console.ReadLine().Split('+');
    Console.WriteLine(int.Parse(str[0]) + int.Parse(str[1]));
}

