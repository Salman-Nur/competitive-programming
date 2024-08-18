string str = Console.ReadLine();
bool c = true;
for (int i = 1; i < str.Length; i++)
{
    if (char.IsLower(str[i]))
    {
        c = false;
    }
}
if (c == true)
{
    for (int j = 0; j < str.Length; j++)
    {
        if (char.IsLower(str[j]))
            Console.Write(char.ToUpper(str[j]));
        else
            Console.Write(char.ToLower(str[j]));
    }
}
else
    Console.WriteLine(str);
