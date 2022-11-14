// Задача 4.
// Написать программу, которая на вход принимаем два числа и проверяет, является ли первое число квадратом второго.

Console.Write("Введите число для проверки квадрата: ");
string number = Console.ReadLine();

Console.Write("Введите число квадрата для проверки: ");
string number2 = Console.ReadLine();

int a = int.Parse(number);
int b = int.Parse(number2);

if ((b * b) == a)
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет");
}