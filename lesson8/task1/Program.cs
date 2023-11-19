// Напишите программу для работы с матрицей целых чисел.

// Реализуйте класс MatrixOperations, который содержит следующие статические методы:

// PrintMatrix(int[,] matrix): Метод для вывода матрицы на экран. Он принимает на вход двумерный массив целых чисел 
// matrix и выводит его элементы в виде таблицы.

// SortRowsDescending(int[,] matrix): Метод для сортировки строк матрицы по убыванию. 
// Он принимает на вход двумерный массив целых чисел matrix и сортирует каждую строку матрицы 
// так, чтобы элементы в каждой строке шли по убыванию.

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] SortRowsDescending(int[,] matrix)
{
    for (int c = 0; c < matrix.GetLength(0); c++)
    {
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            for(int j = 1; j < matrix.GetLength(1); j++)
            {
                int temp = matrix[i,j];
                if(matrix[i,j] > matrix[i,j-1])
                {
                    matrix[i, j] = matrix[i, j - 1];
                    matrix[i, j - 1] = temp;
                }
            }
        }
    }
    return matrix;
}

int[,] matrix = new int[,] {
                {5, 2, 9},
                {8, 1, 4},
                {6, 7, 3}
            };
PrintMatrix(matrix);
Console.WriteLine();
int[,] newMatrix = SortRowsDescending(matrix);
PrintMatrix(newMatrix);