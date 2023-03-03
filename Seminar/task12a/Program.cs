//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

//A (3,6); B (2,1) -> 5,09 
//A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите х1");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите у1");
double y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите х2");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите у2");
double y2 = Convert.ToInt32(Console.ReadLine());

double x3 = Math.Pow(x1-x2, 2);
double y3 = Math.Pow(y1-y2, 2);


Console.WriteLine($"Oтрезок{Math.Sqrt(x3 + y3)}");
