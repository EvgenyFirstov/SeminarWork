// Задача 1.
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);

int n2 = -n;
while (n2 <= n)
{
    Console.Write($"{n2} ");
    n2++;
}