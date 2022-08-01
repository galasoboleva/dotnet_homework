Console.WriteLine("Задача 19: Определить, является ли число палиндромом");
Console.WriteLine("Введите число:");
int input = int.Parse(Console.ReadLine());

bool isPalindrome(int num)
{
    int tempValue = num;
    int reverse = 0;
    while (tempValue > 0)
    {
        reverse = reverse * 10 + tempValue % 10;
        tempValue = tempValue / 10;
    }

    return reverse == num;
}

if (isPalindrome(input)) {
    Console.WriteLine("Да");
} else {
    Console.WriteLine("Нет");
}