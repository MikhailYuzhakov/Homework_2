/*
Задача 1: Напишите программу, которая принимает на
вход трёхзначное число и на выходе показывает вторую
цифру этого числа.
*/

Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 999) {
    Console.WriteLine("Необходимо ввести трехзначное число.");
} else {
    int digit_1 = number / 100; //отсекаем сотни
    number = number - digit_1 * 100;

    int digit_2 = number / 10; //отсекаем десятки
    number = number - digit_2 * 10;

    Console.Write("1-ая цифра числа: "); Console.WriteLine(digit_1);
    Console.Write("2-ая цифра числа: "); Console.WriteLine(digit_2);
    Console.Write("3-ья цифра числа: "); Console.WriteLine(number);
}
