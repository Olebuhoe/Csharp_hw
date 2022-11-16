/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

int DataEntry(string mess)
{
    Console.Write(mess);
    int ratio = Convert.ToInt32(Console.ReadLine());
    return ratio;
}

void IntersectionPoint(double k1, double b1, double k2, double b2)
{
    if (k1 == k2)
    {
        Console.WriteLine("Параллельные прямые пересекаются в бесконечности...");
    }        
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"Координаты точки пересечения прямых ({x}; {y})");
    }
    
}

IntersectionPoint(DataEntry("Введите коэффициент k1: "), DataEntry("Введите коэффициент b1: "), 
                  DataEntry("Введите коэффициент k2: "), DataEntry("Введите коэффициент b2: "));

/*int k1 = DataEntry("Введите коэффициент k1: ");
int b1 = DataEntry("Введите коэффициент b1: ");
int k2 = DataEntry("Введите коэффициент k2: ");
int b2 = DataEntry("Введите коэффициент b2: ");



var direct = new Dictionary<string, int>() 
{
    ["k1"] = 0,
    ["b1"] = 0
};*/