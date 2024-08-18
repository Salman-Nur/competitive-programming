string str = Console.ReadLine().ToLower();
for (int i = 0; i < str.Length; i++)
{
    if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' ||
        str[i] == 'o' || str[i] == 'u' || str[i] == 'y')
    {
        continue;
    }
    else
    {
        Console.Write("." + str[i]);
    }
}
