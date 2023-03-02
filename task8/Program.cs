Console.WriteLine("Введите число N: ");
string strN = Console.ReadLine();
int N = int.Parse(strN);

int count = 1;
int number = 1;

while (count <= N)
{
    if (number % 2 == 0)
    {
        Console.Write(number);
        Console.Write(" ");
    }
    
    number++;
    count++;
}