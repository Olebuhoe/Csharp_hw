/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

int CountPosNum(string str)
{
    string[] charNums = str.Split(new char[] { ',' });    
    int cnt = 0;    
    for (int i = 0; i < charNums.Length; i++)
    {
        if (Convert.ToInt32(charNums[i]) > 0) cnt++;
    }
    return cnt;
}

string a = "0,7,8,-2,-2,8,9";

Console.WriteLine($"Количество чисел больше нуля, введенных пользователем - {CountPosNum(a)}.");


