void PrintArray(int[,] matrix)
{
    // Введите свое решение ниже
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int m = 0; m < matrix.GetLength(1); m++)
        {
            Console.Write($"{matrix[i, m]}\t"); // конвертация строки в вещественное число (string.Format("{0:f}", number))
        }
        Console.WriteLine();
    }
}

int[,] CreateIncreasingMatrix(int n, int m, int k)
{
    // Введите свое решение ниже
    int[,] matrix = new int[n, m];
    int count = 1;

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            matrix[i, j] = count; // записывае каждое предыдущее число + к
            count = matrix[i, j] + k; // Кладем в переменную count сумму которая получилась для того, чтобы дальше к ней прибавлять k
        }
    }
    return matrix;
}

void PrintListAvr(double[] list)
{
    // Введите свое решение ниже
    Console.WriteLine("The averages in columns are:");
    for (int i = 0; i < list.Length; i++)
    {
        Console.Write($"{list[i]:f2}\t");
    }
}

double[] FindAverageInColumns(int[,] matrix)
{
    // Введите свое решение ниже
    double[] avarage = new double[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {   
        double sum = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sum += matrix[j,i];
        }
        avarage[i] = sum / matrix.GetLength(0);
    }
    return avarage;
}        

int[,] result = CreateIncreasingMatrix(3, 4, 2);
PrintArray(result);
PrintListAvr(FindAverageInColumns(result));