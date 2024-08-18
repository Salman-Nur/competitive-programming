
var line = Console.ReadLine().Split(' ');
int prise = int.Parse(line[0]);
int m = int.Parse(line[1]);
int count = 1;

while (true)
{
    if ((count * prise - m) % 10 == 0 || (count * prise) % 10 == 0)
        break;
    count++;
}

Console.WriteLine(count);
