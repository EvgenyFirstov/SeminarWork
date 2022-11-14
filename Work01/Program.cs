// Одноcтрочный комментарий

/* Многострочный комментарий
Добрый
день! :)
*/


// 1. Написать программу, которая на вход принимает число и выдает его квадрат (число умноженное на само себя).

// Вариант 1.

Console.Write("Введи число: ");
int number = int.Parse(Console.ReadLine()!);

// int sqr = number * number;
// Console.WriteLine($"Квадрат числа {number} = {sqr}.");

//Вариант 2 c использованием библиотек

int sqr1 = Convert.ToInt32(Math.Pow(number, 2));
Console.WriteLine($"Квадрат числа {number} = {sqr1}.");
