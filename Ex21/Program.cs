/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/


Console.Clear();

double GetDistancePoints (int x1, int y1, int z1, int x2, int y2, int z2)
{
    double xpow = Math.Pow(x2 -x1, 2);
    double ypow = Math.Pow(y2 -y1, 2);
    double zpow = Math.Pow(z2 -z1, 2);
    double distance = Math.Sqrt(xpow + ypow + zpow);
    return Math.Round(distance, 2, MidpointRounding.ToZero);;
}

Console.WriteLine($"Расстояние между точками AB = {GetDistancePoints(3,6,8,2,1,-7)}");
Console.WriteLine($"Расстояние между точками AB = {GetDistancePoints(7,-5,0,1,-1,9)}");