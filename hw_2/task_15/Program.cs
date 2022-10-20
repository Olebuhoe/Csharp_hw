/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот 
день выходным.
6 -> да
7 -> да
1 -> нет
*/

// Вариант программы с использованием массивов.

void IsWeekend()
{
    Console.WriteLine("Введите номер дня недели: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number > 0 && number < 8)
    {
        int[] weekdays = {1, 2, 3, 4, 5};
        int[] weekends = {6, 7};

        foreach (int num in weekdays)
        {
            if (num == number)
            {
                Console.WriteLine("Нет, это будний день");        
            }
        }
        foreach (int num in weekends)
        {
            if (num == number)
            {
                Console.WriteLine("Да, это выходной");        
            }
        }
    }
    else
    {
        Console.WriteLine("Нет такого дня недели");
    }
    
}

IsWeekend();
