/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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

void PrintArray(double[] array)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}; ");
    }
    Console.WriteLine($"{array[array.Length - 1]}.");
}

double[] AvgArray(int[,] table)
{
    double[] arr = new double[table.GetLength(1)];
    for (int j = 0; j < table.GetLength(1); j++)
    {
        for (int i = 0; i < table.GetLength(0); i++)
        {
            arr[j]+= table[i,j];
        }
        arr[j] = Math.Round(Convert.ToDouble(arr[j]) / table.GetLength(0), 1);        
    }
    return arr;
}


int[,] table = CreateTwoDimArray(5, 5);
PrintTwoDimArray(table);

PrintArray(AvgArray(table));

