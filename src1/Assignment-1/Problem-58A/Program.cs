string str1 = Console.ReadLine();
string str2 = "hello";
int cnt = 0, ok = 0;
for (int i = 0; i < str1.Length; i++)
{
    if (str1[i] == str2[cnt])
    {
        cnt++;
        if (cnt == 5)
        {
            Console.WriteLine("YES");
            ok = 1;
            break;
        }
    }
}
if (ok == 0)
{
    Console.WriteLine("NO");
}