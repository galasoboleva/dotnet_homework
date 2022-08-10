// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
Console.WriteLine("Задача 34: посчитать количество чётных чисел в массиве");
int[] GetArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i + 1 < array.Length)
        {
            Console.Write(",");
        }
    }
    Console.Write("]");
}

int[] numbers = GetArray(4, 100, 999);
int result = 0;

foreach (int num in numbers)
{
    result += num % 2 == 0 ? 1 : 0;
}

PrintArray(numbers);
Console.WriteLine(" => " + result);