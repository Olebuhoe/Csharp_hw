/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

int DataEntry(string mess)
{
    Console.Write(mess);
    int coordinate = Convert.ToInt32(Console.ReadLine());
    return coordinate;
}
int x1 = DataEntry("Введите координату x первой точки: ");
int y1 = DataEntry("Введите координату y первой точки: ");
int z1 = DataEntry("Введите координату z первой точки: ");
int x2 = DataEntry("Введите координату x второй точки: ");
int y2 = DataEntry("Введите координату y второй точки: ");
int z2 = DataEntry("Введите координату z второй точки: ");

Console.Write("Расстояние между этими точками: ");
Console.WriteLine(Math.Round(Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2)), 2));
