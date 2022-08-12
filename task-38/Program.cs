// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.WriteLine("Задача 38: Найти разницу между минимальным и максимальным элементов массива");
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

int calculate(int[] array)
{
    int min = array[0];
    int max = array[0];
    foreach (int number in array)
    {
        min = number < min ? number : min;
        max = number > max ? number : max;
    }
    return max - min;
}

int[] numbers = GetArray(5, 0, 100);
PrintArray(numbers);
Console.WriteLine(" => " + calculate(numbers));