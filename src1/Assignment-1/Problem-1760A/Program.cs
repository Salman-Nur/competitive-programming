﻿int t = int.Parse(Console.ReadLine());  
while (t-- > 0)
{
    int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
    Array.Sort(arr);
    Console.WriteLine(arr[1]);
}
