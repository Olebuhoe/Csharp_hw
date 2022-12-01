/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
Выполнить с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
int RecFunc(int m, int n)
{
    int sum = 0;
    // if (m <= n) sum += RecFunc(m + 1, n) + m;
    if (m <= n) sum += m + RecFunc(m + 1, n);
    return sum;
}

int RecFunc2(int m, int n)
{
    int sum = 0;
    if (m <= n) sum += n + RecFunc(m, n - 1);
    return sum;
}

Console.WriteLine(RecFunc(4, 8));
Console.WriteLine(RecFunc2(1, 15));