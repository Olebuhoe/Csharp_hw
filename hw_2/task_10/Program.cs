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
    if (number > 99 && number < 1000)
    {
        int trdPos = number / 10;
        int sndPos = trdPos % 10;
        Console.WriteLine(sndPos);
    }
    else if (number < -99 && number > -1000)
    {
        int trdPos = number / 10;
        int sndPos = -(trdPos % 10);
        Console.WriteLine(sndPos);
    }
    else
    {
        Console.WriteLine("Вы ввели не трёхзначное число!");
    }    
}

SndPosition();
