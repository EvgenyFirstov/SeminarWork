// Задача 5.
// Написать программу, которая будет выдавать название дня недели по заданному номеру.

Console.Write("Введите номер дня недели от 1 до 7: ");
int number_day = int.Parse(Console.ReadLine()!);

if (number_day == 1) { Console.WriteLine($"{number_day} день недели - это Понедельник!"); }
else if (number_day == 2) { Console.WriteLine($"{number_day} день недели - это Вторник!"); }
else if (number_day == 3) { Console.WriteLine($"{number_day} день недели - это Среда!"); }
else if (number_day == 4) { Console.WriteLine($"{number_day} день недели - это Четверг!"); }
else if (number_day == 5) { Console.WriteLine($"{number_day} день недели - это Птяница!"); }
else if (number_day == 6) { Console.WriteLine($"{number_day} день недели - это Суббота!"); }
else if (number_day == 7) { Console.WriteLine($"{number_day} день недели - это Воскресенье!"); }
else { Console.WriteLine("Что-то не так! Подумай!"); }