// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях
Console.WriteLine("Задача 36: посчитать сумму чисел, стоящих на нечётных позициях в массиве");
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

int[] numbers = GetArray(4, -100, 100);
int result = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (i % 2 != 0) {
        result += numbers[i];
    }
}

PrintArray(numbers);
Console.WriteLine(" => " + result);