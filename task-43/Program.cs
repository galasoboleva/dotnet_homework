// Задача 43: 
// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
//
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
Console.WriteLine("Задача 43: Найти точку пересечения двух прямых, заданных уравнением y = k * x + b");

/*
Первое уравнение
y = k1 * x + b1

Второе уравнение, приводим к общему уравнению прямой
y = k2 * x + b2  =>  k2 * x - y + b2 = 0

Подставляем первое уравнение во второе
k2 * x - (k1 * x + b1) + b2 = 0  =>
    k2 * x - k1 * x - b1 + b2 = 0 =>
        k2 * x - k1 * x = b1 - b2  =>
            (k2 - k1) * x = b1 - b2  =>  
                x = (b1 - b2) / (k2 - k1)
*/

(float b, float k) RequestParams(int count)
{
    Console.WriteLine($"Введите b{count}:");
    float b = float.Parse(Console.ReadLine());

    Console.WriteLine($"Введите k{count}:");
    float k = float.Parse(Console.ReadLine());

    return (b, k);
}

void PrintEquation(int count, (float b, float k) eq)
{
    Console.WriteLine($"Уравнение прямой #{count}: y = {eq.k}x + {eq.b};");
}

(float x, float y) FindIntersectionPoint ((float b, float k) eq1, (float b, float k) eq2)
{
    float b = eq1.b - eq2.b;
    float k = eq2.k - eq1.k;
    float x = b / k;
    float y = eq1.k * x + eq1.b;

    return (x, y);
}

(float b, float k) eq1 = RequestParams(1);

PrintEquation(1, eq1);

(float b, float k) eq2 = RequestParams(2);

PrintEquation(1, eq2);

(float x, float y) point = FindIntersectionPoint(eq1, eq2);

Console.WriteLine($"Точка пересечения: ({point.x}, {point.y})");
