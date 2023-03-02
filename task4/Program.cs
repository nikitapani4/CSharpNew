Console.Write("Введите число a: ");
string strA = Console.ReadLine();
int a = int.Parse(strA);
Console.Write("Введите число b: ");
string strB = Console.ReadLine();
int b = int.Parse(strB);
Console.Write("Введите число c: ");
string strC = Console.ReadLine();
int c = int.Parse(strC);

int max = a;

if (b > max) max = b;
if (c > max) max = c;

Console.Write("max = ");
Console.WriteLine(max);