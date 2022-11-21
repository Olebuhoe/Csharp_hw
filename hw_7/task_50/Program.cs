/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение
этого элемента или же указание, что такого элемента нет. Во вводе первая цифра - номер строки, вторая - столбца.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

double[,] CreateTwoDimArray(int m, int n)
{
    double[,] matrix = new double[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(rnd.Next(-10, 11) * rnd.NextDouble(), 1);
        }
    }
    return matrix;
}

void PrintTwoDimArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void GetItem(double[,] matrix)
{
    Console.Write("Введите двухзначное число, где первая цифра - номер строки, вторая - номер столбца матрицы: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number / 10 > matrix.GetLength(0) || number % 10 > matrix.GetLength(1) || number % 10 == 0)
        Console.WriteLine("Такого числа в массиве нет");
    else Console.WriteLine(matrix[number / 10 - 1, number % 10 - 1]);
}

double[,] table = CreateTwoDimArray(3, 3);
PrintTwoDimArray(table);
GetItem(table);
