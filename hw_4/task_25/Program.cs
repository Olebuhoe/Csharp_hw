/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int EnterNum(string mess)
{
    Console.Write(mess);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int Exponentiation(int numA, int numB)
{
    int numC = 1;

    for (int i = 0; i < numB; i++)
    {
        numC *= numA;
    }

    return numC;
}

Console.WriteLine(Exponentiation(EnterNum("Введите первое число: "), EnterNum("Введите второе число: ")));
