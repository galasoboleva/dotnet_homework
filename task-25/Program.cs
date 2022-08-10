// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("Задача 25: Возвести число А в степень B");
Console.WriteLine("Введите число A:");
int numA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B:");
int numB = int.Parse(Console.ReadLine());

int result = numA;
for (int i = 1; i < numB; i++) {
    result = result * numA;
}
Console.WriteLine($"Результат: {result}");