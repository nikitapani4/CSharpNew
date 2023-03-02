Console.Write("Введите число a: ");
string strA = Console.ReadLine();
int a = int.Parse(strA);
Console.Write("Введите число b: ");
string strB = Console.ReadLine();
int b = int.Parse(strB);

int max;

if (a > b)
{
    max = a;
    Console.Write("max = ");
    Console.WriteLine(max);
}

else
{
    max = b;
    Console.Write("max = ");
    Console.WriteLine(max);
}