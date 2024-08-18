HashSet<char> st = new HashSet<char>();
string str = Console.ReadLine();
for (int i = 0; i < str.Length; i++)
{
    st.Add(str[i]);
}
Console.WriteLine(st.Count < 3 ? 0 : st.Count == 3 ? 1 : st.Count - 4);