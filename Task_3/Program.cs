/*
Задача 3: Напишите программу, которая выводит третью
цифру заданного числа или сообщает, что третьей цифры
нет
*/

Console.Clear();
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[20];
int i = 0;

while (number > 0) {
    array[i] = number % 10;
    number = number / 10;
    //Console.WriteLine(array[i]);
    i++;
}

if (i - 3 < 0) {
    Console.Write("Третья цифра отутствует.");
} else {
    Console.Write("Третья цифра числа: ");
Console.WriteLine(array[i - 3]);
}
