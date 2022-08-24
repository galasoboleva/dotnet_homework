/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

Console.WriteLine("Задача 52: Найти среднее арифметическое элементов в каждом столбце двумерного массива");

int[,] GetArray(int rows, int cols)
{
    int[,] array = new int[rows, cols];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }

    return array;
}

void PrintLine(int count) 
{
    for (int j = 0; j < count; j++)
    {
        Console.Write("----");
    }
    Console.WriteLine();
}

void PrintArray(int[,] array)
{
    int rows = array.GetUpperBound(0) + 1;
    int columns = array.GetUpperBound(1) + 1;

    PrintLine(columns);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(" " + array[i, j] + "  ");
        }
        Console.WriteLine();
    }

    PrintLine(columns);
}

decimal[] CalculateAverage(int[,] array)
{
    
    int rows = array.GetUpperBound(0) + 1;
    int columns = array.GetUpperBound(1) + 1;
    int[] total = new int[columns];
    decimal[] avg = new decimal[columns];

    for (int r = 0; r < rows; r++)
    {
        for (int c = 0; c < columns; c++)
        {
            total[c] += array[r, c];
        }
    }

    for (int i = 0; i < columns; i++)
    {
        avg[i] = decimal.Parse(total[i].ToString()) / rows;
    }

    return avg;
}

int[,] array = GetArray(3, 4);
decimal[] avg = CalculateAverage(array);

PrintArray(array);

foreach(decimal x in avg) 
{
    Console.Write(x.ToString("0.0") + " ");
}
Console.WriteLine();