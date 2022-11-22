/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int[,] CreateTwoDimArray(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(0, 10);
        }
    }
    return matrix;
}

void PrintTwoDimArray(int[,] matrix)
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

int[,] SortTwoDimArray(int[,] matrix)
{
    for (int k = 0; k < matrix.GetLength(0); k++)
    {      
        for (int i = 0; i < matrix.GetLength(1) - 1; i++)
        {
            int maxPos = i;

            for (int j = i + 1; j < matrix.GetLength(1); j++)
            {
                if (matrix[k, j] > matrix[k, maxPos])
                {
                    maxPos = j;
                }
            }

            int temp = matrix[k, i];
            matrix[k, i] = matrix[k, maxPos];
            matrix[k, maxPos] = temp;
        }
    }
    return matrix;    
}

int[,] mtrx = CreateTwoDimArray(3, 5);
PrintTwoDimArray(mtrx);
Console.WriteLine();
PrintTwoDimArray(SortTwoDimArray(mtrx));
