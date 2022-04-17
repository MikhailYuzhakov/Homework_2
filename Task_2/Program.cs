/*
Задача 2: Напишите программу, которая выводит
случайное трёхзначное число и удаляет вторую цифру
этого числа.
*/

Console.Clear();
int number = new Random().Next(0, 999);
Console.Write("Случайное трехзначное число: ");
Console.WriteLine(number);

int digit_1 = number / 100; //отсекаем сотни
number = number - digit_1 * 100;

int digit_2 = number / 10; //отсекаем десятки
number = number - digit_2 * 10;

number = digit_1 * 10 + number;

Console.Write("Результат работы программы: ");
Console.WriteLine(number);
