/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 
(Использовать только математические операции, нельзя использовать число как строку по типу number[1])
456 -> 5
782 -> 8
918 -> 1
*/

void SndPosition()
{
    Console.WriteLine("Введите трёхзначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if ((number > 99 && number < 1000) || (number < -99 && number > -1000))
    {
        Console.WriteLine(Math.Abs(number / 10 % 10));
    }
    else
    {
        Console.WriteLine("Вы ввели не трёхзначное число!");
    }    
}

SndPosition();
