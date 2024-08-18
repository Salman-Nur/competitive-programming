
var positions = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
Array.Sort(positions);
Console.WriteLine(positions[2] - positions[0]);
