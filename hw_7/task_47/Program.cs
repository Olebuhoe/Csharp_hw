﻿/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
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

PrintTwoDimArray(CreateTwoDimArray(3, 4));

// Подскажите, пжл, как можно прописать метод PrintTwoDimArray(), чтобы он принимал на выведение массив с любым типом
// данных внутри, а не только double, как в данном случае?

