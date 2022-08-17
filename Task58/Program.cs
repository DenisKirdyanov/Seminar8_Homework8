// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Console.WriteLine("Введите количество строк матриц: ");
int rows = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов матриц: ");
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

double[,] array1 = GetArray(rows, columns, 0, 50);
double[,] array2 = GetArray(rows, columns, 0, 50);

PrintArray(array1);
Console.WriteLine();
PrintArray(array2);
Console.WriteLine();

void GetNewArray(double[,] localArray1, double[,] localArray2)
{
    double[,] NewArray = new double[localArray1.GetLength(0), localArray1.GetLength(1)];
    for (int i = 0; i < localArray1.GetLength(0); i++)
    {
        for (int j = 0; j < localArray1.GetLength(1); j++)
        {
            NewArray[i, j] = localArray1[i, j] * localArray2[i, j];
        }
    }
    PrintArray(NewArray);
}
GetNewArray(array1, array2);
