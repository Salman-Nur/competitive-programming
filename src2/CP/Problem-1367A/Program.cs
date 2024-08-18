
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    string s = Console.ReadLine();
    string res = "";
    for (int j = 0; j < s.Length; j += 2)
    {
        res += s[j];
    }
    res += s[s.Length - 1];
    Console.WriteLine(res);
}
