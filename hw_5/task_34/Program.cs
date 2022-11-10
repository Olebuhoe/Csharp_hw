/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет 
количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int[] CreateArray(int n)
{
    int[] arr = new int[n];
    Random rnd = new Random();
    for (int i = 0; i < n; i++)
    {
        arr[i] = rnd.Next(100, 1000);
    }
    return arr;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[array.Length - 1]}]");
}

int CountEvenNum(int[] array)
{
    int cnt = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) cnt++;        
    }
    return cnt;
}

int[] arr = CreateArray(7);
PrintArray(arr);
Console.WriteLine($"Количество четных элементов данного массива равно {CountEvenNum(arr)}.");
