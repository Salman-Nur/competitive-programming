
int n = int.Parse(Console.ReadLine());
int m = 0, c = 0;

for (int i = 0; i < n; i++)
{
    string[] nums = Console.ReadLine().Split();
    int a = int.Parse(nums[0]);
    int b = int.Parse(nums[1]);

    if (a > b) m++;
    else if (a < b) c++;
    else continue;
}

if (c > m) Console.WriteLine("Chris");
else if (m > c) Console.WriteLine("Mishka");
else Console.WriteLine("Friendship is magic!^^");
