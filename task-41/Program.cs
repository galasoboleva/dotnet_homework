// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
//
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.WriteLine("Задача 41: Посчитать числа, которые больше 0");

int max = 10;
int count = 0;
int result = 0;

while(count < max)
{
    Console.WriteLine($"Введите число ({count+1} из {max}):");
    
    string input = Console.ReadLine();
    if (string.IsNullOrEmpty(input)) {
        count = 10;
    } else {
        int number = int.Parse(input);
        count++;
        if (number > 0) {
            result++;
        }
        Console.WriteLine("Положительных значений: " + result);
    }
}