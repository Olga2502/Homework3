//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
//между ними в 3D пространстве.

Console.Clear();

Console.WriteLine("Введите координату x1 :");
int x1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату y1 :");
int y1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату z1 :");
int z1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату второй точки x2:");
int x2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату второй точки y2 :");
int y2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату второй точки z2:");
int z2 = int.Parse(Console.ReadLine()!);

double yy = Math.Pow((y1 - y2), 2);
double zz = Math.Pow((z1 -z2), 2);
double xx = Math.Pow((x1 - x2), 2);
double a = Math.Sqrt(yy + xx + zz);
//a = Math.Round(a, 2);
Console.WriteLine($"Расстояние между точками равно:  {a:f2} ");