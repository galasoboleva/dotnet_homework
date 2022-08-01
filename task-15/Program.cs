Console.WriteLine("Задача 15: Проверить, является ли день выходным");
Console.WriteLine("Введите номер дня недели:");
int day = int.Parse(Console.ReadLine());
if (day > 5 && day <= 7) {
    Console.WriteLine("Да");
} else if (day > 0 && day <= 5) {
    Console.WriteLine("Нет");
} else {
    Console.WriteLine("Неверное значение");
}