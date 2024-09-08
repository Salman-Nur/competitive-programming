

List<int> list1 = new List<int>{ 1, 1, 4, 5 };
List<int> list2 = new List<int> { 2, 2, 3 };

List<int> set = new List<int>();
foreach (var item in list1)
{
    set.Add(item);
}
foreach (var item in list2)
{
    set.Add(item);
}
set.Sort();
foreach (var item in set)
{
    Console.WriteLine(item);
}