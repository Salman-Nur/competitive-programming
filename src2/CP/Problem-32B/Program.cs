
string str = Console.ReadLine();

for(int i = 0; i < str.Length; i++)
{
    if(str[i] == '.')
    {
        Console.Write(0);
    }
    else if(str[i] == '-' && str[i + 1] == '.')
    {
        Console.Write(1);
        i++;
    }
    else
    {
        Console.Write(2);
        i++;
    }
}
