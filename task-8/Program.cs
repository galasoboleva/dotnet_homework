Console.WriteLine("Задача 8: Показать все чётные числа от 1 до N.");
Console.WriteLine("Введите число:");
int N = int.Parse(Console.ReadLine());
for (int i = 2; i <= N; i = i + 2) {
    Console.Write($"{i} ");
}