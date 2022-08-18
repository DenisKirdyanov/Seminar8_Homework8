// Задача 62. Заполните спирально массив 4 на 4.

Console.WriteLine("Введите количество строк матриц: ");
int N = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов матриц: ");
int M = int.Parse(Console.ReadLine());

void PrintArray(int nn, int mm)
{
    int[,] Array = new int[N, M];

    int Ibeg = 0, Ifin = 0, Jbeg = 0, Jfin = 0;
    int k = 1;
    int i = 0;
    int j = 0;

    while (k <= N * M)
    {
        Array[i, j] = k;
        if (i == Ibeg && j < M - Jfin - 1) j++;
        else if (j == M - Jfin - 1 && i < N - Ifin - 1) i++;
        else if (i == N - Ifin - 1 && j > Jbeg) j--;
        else i--;

        if ((i == Ibeg + 1) && (j == Jbeg) && (Jbeg != M - Jfin - 1))
        {
            Ibeg++;
            Ifin++;
            Jbeg++;
            Jfin++;
        }
        k++;
    }

    for (int ii = 0; ii < Array.GetLength(0); ii++)
    {
        for (int jj = 0; jj < Array.GetLength(1); jj++)
        {
            Console.Write($" {Array[ii, jj]} ");
        }
        Console.WriteLine();
    }
}

PrintArray(N, M);
