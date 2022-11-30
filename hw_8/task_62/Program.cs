/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

// Решение не очень нравится, т.к. оно очень локальное и работает только для матрицы 4*4. Нашел в тырнете более универсальные 
// варианты, но копипастить не вижу смысла, а свой вариант не додумал...

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

int[,] SpiralMatrix4x4(int x)
{
    int[,] array = new int[4, 4];

    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[0, j] = x;
        x++;
    }
    for (int i = 1; i < array.GetLength(0); i++)
    {
        array[i, array.GetLength(1) - 1] = x;
        x++;
    }
    for (int j = array.GetLength(1) - 2; j > -1; j--)
    {
        array[array.GetLength(0) - 1, j] = x;
        x++;
    }
    for (int i = array.GetLength(0) - 2; i > 0; i--)
    {
        array[i, 0] = x;
        x++;
    }
    for (int j = 1; j < array.GetLength(1) - 1; j++)
    {
        array[1, j] = x;
        x++;
    }
    for (int j = array.GetLength(1) - 2; j > 0; j--)
    {
        array[2, j] = x;
        x++;
    }
    return array;
}
PrintTwoDimArray(SpiralMatrix4x4(10));





