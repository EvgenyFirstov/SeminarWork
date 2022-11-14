// Задача 3.
Console.Write("Введите трёхзначное число: ");
int n = int.Parse(Console.ReadLine()!);
int S = n % 10;
Console.WriteLine($"Третье число = {S}");