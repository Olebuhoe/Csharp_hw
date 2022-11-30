/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
string RecFunc(int n)
{
    if (n == 1) return "1";
    return $"{n}, " + RecFunc(n - 1);
}

string RecFunc2(int n)
{
    if (n > 1) return $"{n}, " + RecFunc2(n - 1);
    return "1";
}

string RecFunc3(int n) // но тут лишняя запятая и +1 шаг рекурсии
{
    if (n >= 1) return $"{n}, " + RecFunc3(n - 1);
    return String.Empty;
}

Console.WriteLine(RecFunc(7));
Console.WriteLine(RecFunc2(7));
Console.WriteLine(RecFunc3(7));