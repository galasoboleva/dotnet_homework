Console.WriteLine("Задача 13: Показать третью цифру числа");
Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine());
if (num < 100) {
    Console.WriteLine("третьей цифры нет");
} else {
    while (num > 1000) {
        num = num/10;
    }
    int result = num%10;
    Console.WriteLine(result);
}