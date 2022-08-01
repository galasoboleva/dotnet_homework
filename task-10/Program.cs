Console.WriteLine("Задача 10: Показать вторую цифру трехзначного числа");
Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine());
int fraction = num/10;
int result = fraction%10;
Console.WriteLine(result);