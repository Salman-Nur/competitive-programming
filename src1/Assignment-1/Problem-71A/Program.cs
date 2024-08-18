int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    string str = Console.ReadLine();
    int length = str.Length;
    if (length > 10)
    {
        Console.Write(str[0]);
        Console.Write(length - 2);
        Console.WriteLine(str[length - 1]);
        //Console.WriteLine("" + str[0] + (length - 2) + str[length - 1]);
    }
    else
    {
        Console.WriteLine(str);
    }

}