/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
while (number <= 1)
{
    Console.WriteLine("Число должно быть положительным и больше 1. Введите число: ");
    number = Convert.ToInt32(Console.ReadLine());
}
if (number % 2 != 0)
{
    number -= 1;
}
Console.WriteLine("Лови чётные числа:");
while (number > 1)
{
    Console.WriteLine(number);
    number -= 2;
}