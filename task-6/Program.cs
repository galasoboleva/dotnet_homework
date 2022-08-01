Console.WriteLine("Задача 6: Проверить, является ли число чётным");
Console.WriteLine("Введите число:");
int a = int.Parse(Console.ReadLine());
if (a % 2 == 0) {
    Console.WriteLine("Да");
} else {
    Console.WriteLine("Нет");
}