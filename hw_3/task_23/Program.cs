/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.Write("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int num = 1;

if (number <= 0)
{
    Console.WriteLine("Это не положительное число!");
}
else
{
    while (num < number)
    {
        Console.Write(num * num * num + ", ");
        num++;
    }
    Console.WriteLine(number * number * number);
}