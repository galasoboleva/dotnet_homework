Console.WriteLine("Задача 21: Определить расстояние между двуми точками в 3D пространстве");
Console.WriteLine("Введите x1");
int x1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите y1");
int y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите z1");
int z1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите x2");
int x2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите y2");
int y2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите z2");
int z2 = int.Parse(Console.ReadLine());

Console.WriteLine($"Точка A({x1}, {y1}, {z1})");
Console.WriteLine($"Точка B({x2}, {y2}, {z2})");

double SquareDiff(int a, int b)
{
    return Math.Pow(a - b, 2);
}

double Distance(int X1, int Y1, int Z1, int X2, int Y2, int Z2)
{
    return Math.Sqrt(SquareDiff(X1, X2) + SquareDiff(Y1, Y2) + SquareDiff(Z1, Z2));
}

double distance = Math.Round(Distance(x1, y1, z1, x2, y2, z2), 2);

Console.WriteLine($"Расстояние: {distance}");