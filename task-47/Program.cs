// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Задача 47: Двумерный массив M*N");
int m = 3;
int n = 4;

int[,] GetArray(int m, int n)
{
    int[,] array = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(-99, 100);
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

int [,] array = GetArray(3, 4);

PrintArray(array);


