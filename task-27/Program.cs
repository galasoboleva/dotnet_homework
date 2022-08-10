// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Задача 27: Вывести сумму цифр в числе");

int SumOfDigits(int number) 
{
    int sum = 0;
    while(number > 0) {
        sum = sum + (number%10);
        number = number / 10;
    }
    return sum;
}

Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine());

Console.WriteLine(SumOfDigits(num));
