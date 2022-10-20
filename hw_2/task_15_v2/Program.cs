/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот 
день выходным.
6 -> да
7 -> да
1 -> нет
*/

void IsWeekend()
{
    Console.WriteLine("Введите номер дня недели: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number >= 1 && number <= 5)
    {
        Console.WriteLine("Нет, это будний день");
    }
    else if (number == 6 || number == 7)
    {
        Console.WriteLine("Да, это выходной");
    }
    else
    {
        Console.WriteLine("Нет такого дня недели");
    }
}

IsWeekend();
