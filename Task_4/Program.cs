// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
Задача 4: Напишите программу, которая принимает на
вход цифру, обозначающую день недели, и проверяет,
является ли этот день выходным.
*/

Console.Clear();
Console.WriteLine("Введите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());

switch (day)
{
    case 1:
        Console.WriteLine("Первый рабочий день D:");
        break;

    case 2:
        Console.WriteLine("Рабочий день :(");
        break;
    
    case 3:
        Console.WriteLine("Рабочий день :(");
        break;

    case 4:
        Console.WriteLine("Рабочий день :(");
        break;

    case 5:
        Console.WriteLine("Последний рабочий день :|");
        break;

    case 6:
        Console.WriteLine("Выходной день :)");
        break;

    case 7:
        Console.WriteLine("Выходной день :D");
        break;

    default:
        Console.WriteLine("Вы ввели неверные данные.");
        break;
}
