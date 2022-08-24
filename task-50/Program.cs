// Задача 50. Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

Console.WriteLine("Задача 50: Показать значение элемента двумерного массива");

int[,] GetArray(int rows, int cols)
{
    int[,] array = new int[rows, cols];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[i, j] = new Random().Next(0, 100);
        }
    }

    return array;
}

void PrintArray(int[,] array)
{
    int rows = array.GetUpperBound(0) + 1;
    int columns = array.GetUpperBound(1) + 1;

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write( array[i, j] + "  ");
        }
        Console.WriteLine();
    }
}

int[,] array = GetArray(4, 4);

PrintArray(array);

Console.WriteLine("Введите № строки:");
int row = int.Parse(Console.ReadLine());

Console.WriteLine("Введите № колонки:");
int col = int.Parse(Console.ReadLine());

if (row - 1 < array.GetLength(0) && col - 1 < array.GetLength(1)) 
{
    Console.WriteLine($"[{row}, {col}] => {array[row - 1, col - 1]}");
} 
else 
{
    Console.WriteLine($"[{row}, {col}] => такого элемента в массиве нет");
}
