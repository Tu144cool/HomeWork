// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

Console.Write("Введите координаты Xa ");
double Xa = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Введите координаты Ya ");
double Ya = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Введите координаты Za ");
double Za = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Введите координаты Xb ");
double Xb = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Введите координаты Yb ");
double Yb = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Введите координаты Zb ");
double Zb = Convert.ToDouble(Console.ReadLine()!);

double x = Math.Sqrt(Math.Pow(Xb-Xa, 2) + Math.Pow(Yb-Ya, 2) + Math.Pow(Zb-Za, 2));
Console.Write($"Расстояние ежду точками равно {x:f2}");