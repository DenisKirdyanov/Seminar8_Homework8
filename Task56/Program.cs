// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

double[,] GetArray(int m, int n, int min, int max)
{
    double[,] result = new double[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
    }
    return result;
}

void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($" {inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

double[,] array = GetArray(rows, columns, 0, 50);

PrintArray(array);
Console.WriteLine();

void GetRank(double[,] localArray)
{
    double[] TempArray = new double[localArray.GetLength(0)];

    for (int i = 0; i < localArray.GetLength(0); i++)
    {
        double s = 0;
        for (int j = 0; j < localArray.GetLength(1); j++)
        {
            s = s + localArray[i, j];
        }
        TempArray[i] = s;
    }
    foreach (int i in TempArray)
    {
        Console.Write($" {i} ");
    }
    Console.WriteLine();
    double min = TempArray[0];
    int k = 0;
    for (int i = 1; i < TempArray.Length; i++)
    {
        if (TempArray[i] < min)
        {
            min = TempArray[i];
            k = i;
        }
    }
    Console.Write($"Строка с наименьшей суммой: {k + 1} ");
}

GetRank(array);
