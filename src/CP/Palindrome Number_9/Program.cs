string str1 = Console.ReadLine();

var str2 = new string(str1.Reverse().ToArray());

if (str1 == str2)
{
    Console.WriteLine("true");
}
else
{
    Console.WriteLine("false");
}
