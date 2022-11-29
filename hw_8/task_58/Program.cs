/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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

void MultiplicationTwoMatrixs(int[,] matrix1, int[,] matrix2)
{
    if (matrix1.GetLength(1) != matrix2.GetLength(0))
        Console.WriteLine("Эти матрицы перемножить нельзя!");
    else
    {
        int[,] matrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];    
        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                for (int k = 0; k < matrix2.GetLength(0); k++)
                {
                    matrix[i, j] += matrix1[i, k] * matrix2[k, j];
                }            
            }
        }
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }    
}

int[,] arr1 = CreateTwoDimArray(2, 2);
int[,] arr2 = CreateTwoDimArray(2, 2);
PrintTwoDimArray(arr1);
Console.WriteLine();
PrintTwoDimArray(arr2);
Console.WriteLine();
// int[,] arr1 = {{2, 4}, {3, 2}};
// int[,] arr2 = {{3, 4}, {3, 3}};
MultiplicationTwoMatrixs(arr1, arr2);


