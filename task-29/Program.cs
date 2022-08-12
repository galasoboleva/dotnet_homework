// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Console.WriteLine("Задача 29: Вывести массив на экран");
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
    Console.WriteLine("]");
}

int[] numbers = GetArray(8, -100, 100);
PrintArray(numbers);