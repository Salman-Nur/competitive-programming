﻿int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);
Array.Sort(arr);
int x1 = arr[0];
int x2 = arr[1];
int x3 = arr[2];
int x4 = arr[3];
int a = x4 - x1;
int b = x4 - x2;
int c = x4 - x3;
Console.WriteLine(a + " " + b + " " + c);