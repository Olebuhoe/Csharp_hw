/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

int[] CreateArray(int n)
{
    int[] arr = new int[n];
    Random rnd = new Random();
    for (int i = 0; i < n; i++)
    {
        arr[i] = rnd.Next(0, 100);
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

int MaxElem(int[] array)
{
    int maxElement = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > maxElement) maxElement = array[i];
    }
    return maxElement;
}

int MinElem(int[] array)
{
    int minElement = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minElement) minElement = array[i];
    }
    return minElement;
}

int[] arr = CreateArray(7);
PrintArray(arr);
//Console.WriteLine(MaxElem(arr));
//Console.WriteLine(MinElem(arr));
Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {MaxElem(arr) - MinElem(arr)}.");
