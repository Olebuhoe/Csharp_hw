/*
Задача 60. ...Сформируйте трёхмерный массив из случайных неповторяющихся двузначных чисел. Напишите программу, 
которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

List<int> CreateListFrom10To99()
{
    int[] arr = new int[90];
    for (int i = 0; i < arr.Length; i++) arr[i] = i + 10;    
    List<int> lst = new List<int>(arr);
    return lst;
}
// Почему-то не получилось создать список через код ниже:

/*List<int> lst = new List<int>(90);
for (int i = 0; i < lst.Count; i++) lst.Add(i + 10);

пришлось через массив...*/

int[,,] CreateThreeDimArray(int x, int y, int z)
{
    int[,,] matrix = new int[x, y, z];
    List<int> lst = CreateListFrom10To99();
    Random rnd = new Random();
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                int m = rnd.Next(0, lst.Count);
                matrix[i, j, k] = lst[m];
                lst.RemoveAt(m);
            }
        }
    }
    return matrix;
}

void PrintThreeDimArray(int[,,] matrix)
{
    for (int k = 0; k < matrix.GetLength(2); k++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

PrintThreeDimArray(CreateThreeDimArray(2, 2, 2));
