﻿/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

// Не стал разбивать на функции, т.к. было бы примерно то же, что и в задаче 25.

long num = 1233275958223412;
long temp = num;
long b = 0;

while (num > 0)
{
    long a = num % 10;
    b += a;
    num /= 10;
}

Console.WriteLine($"Сумма цифр в числе {temp} равна {b}.");
