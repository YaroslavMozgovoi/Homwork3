// Задача 21
// 1.Напишите программу, которая принимает на вход координаты двух точек.  
// 2.Находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точек:");
Console.WriteLine("x1: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y1: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("z1: ");
int za = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("x2: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y2: ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("z2: ");
int zb = Convert.ToInt32(Console.ReadLine());

double Distance(int x1, int y1, int z1, int x2,int y2, int z2)
{
    double res = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)+ Math.Pow((z2 - z1), 2));
    return res;
}

double distance = Distance(xa, ya, za, xb, yb, zb);
distance = Math.Round(distance,2,MidpointRounding.ToZero);
Console.WriteLine(distance);
