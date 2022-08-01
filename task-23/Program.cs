Console.WriteLine("Задача 23: Показать таблицу кубов чисел от 1 до N.");
Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine());
for (int i = 1; i <= num; i++) {
    var result = Math.Pow(i, 3);
    Console.Write($"{result} ");
}