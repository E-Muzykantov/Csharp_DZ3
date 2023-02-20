/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

void CubeTableN(int n)
{
    for (int i = 1; i <= n; i++)
    {
        Console.Write($"{Math.Pow(i, 3)}");
        Console.Write(i == n ? "." : ", ");
    }
}

Console.Write($"{n} -> "); CubeTableN(n);

/*
Задача 23 (Вариант с семинара)
Напишите программу, которая принимает на вход 2 числа (N,M) и выдаёт таблицу кубов чисел от N до M.
2,3 -> 8, 27
1,5 -> 1, 8, 27, 64, 125
*/

Console.WriteLine();
Console.WriteLine("Второй вариант задачи с семинара");

Console.Write("Введите первое число: ");
int j = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int k = Convert.ToInt32(Console.ReadLine());

void CubeTableJK(int j, int k)
{

    for (; j <= k; j++)
    {
        Console.Write($"{Math.Pow(j, 3)}");
        Console.Write(j == k ? "." : ", ");
    }
}

Console.Write($"{j}, {k} -> "); CubeTableJK(j, k);
