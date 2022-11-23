/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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

void StringMinSumItem(int[,] mtrx)
{
    int[] array = new int[mtrx.GetLength(0)];
    for (int i = 0; i < mtrx.GetLength(0); i++)
        {        
            array[i] = 0;
            for (int j = 0; j < mtrx.GetLength(1); j++)        
            {
                array[i] += mtrx[i, j];
            }
        }    

    int minPosition = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < array[minPosition]) minPosition = i;
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов - {minPosition + 1}");
}

int[,] matrix = CreateTwoDimArray(4, 4);
PrintTwoDimArray(matrix);
StringMinSumItem(matrix);
