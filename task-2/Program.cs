Console.WriteLine("Задача 2: Вывести наибольшее из двух чисел");
Console.WriteLine("Введите первое число:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int b = int.Parse(Console.ReadLine());
int max = a;
if (b > max) {
    max = b;
}
Console.WriteLine($"Max: {max}");