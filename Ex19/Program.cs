/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.Clear();

Console.Write("Введите число: ");
string array = (Console.ReadLine());
int length = array.Length;
string result = String.Empty;

string CheckIsPolindrom(string array)
{
    for (int i = 0, j = length - 1; i < length / 2; i++, j--)
    {
        if (array[i] == array[j]) result = "Да";
        else 
        {
            result = "Нет";
            break; // исправил ошибку
        }
    }
    return result;
    
}

Console.Write($"{array} -> {CheckIsPolindrom (array)}");
