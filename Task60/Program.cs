// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//            Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Console.WriteLine("Введите размер X трехмерного массива: ");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Введите размер Y трехмерного массива: ");
int y = int.Parse(Console.ReadLine());

Console.WriteLine("Введите размер Z трехмерного массива: ");
int z = int.Parse(Console.ReadLine());

double[,,] GetArray(int m, int n, int l, int min, int max)
{
    double[,,] result = new double[m, n, l];

    int flag = 1;

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < l; k++)
            {                
                result[i,j,k] = new Random().Next(min, max + 1)*new Random().Next(min, max + 1)/new Random().Next(min, max + 1);

                    for (int ii = 0; ii < result.GetLength(0); ii++)
                    {
                        for (int jj = 0; jj < result.GetLength(1); jj++)
                        {
                            for (int kk = 0; kk < result.GetLength(2); kk++)
                            {
                                if (result[ii, jj, kk] == result[i, j, k]) result[i, j, k] = new Random().Next(min, max + 1);
                            }
                        }
                    }                    
                
            }
        }
    }
    return result;
}

void PrintArray(double[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Console.Write($" {inArray[i, j, k]} ({i}, {j}, {k}) ");
            }
        }
        Console.WriteLine();
    }
}

double[,,] array = GetArray(x, y, z, 10, 99);

PrintArray(array);