int t = int.Parse(Console.ReadLine());
char[] ch = { 'c', 'o', 'd', 'e', 'f', 'r', 's' };
while (t-- > 0)
{
    char c = char.Parse(Console.ReadLine());
    Console.WriteLine(ch.Contains(c) ? "YES" : "NO");
}
