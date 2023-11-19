// Напишите программу для работы с матрицей целых чисел.
// Реализуйте класс Answer, который содержит следующие статические методы:
// SumOfRow(int[,] matrix, int row): Метод для вычисления суммы элементов в заданной строке row матрицы matrix. 
// Метод принимает двумерный массив целых чисел matrix и номер строки row, 
// а возвращает целое число - сумму элементов в данной строке.
// MinimumSumRow(int[,] matrix): Метод для определения строки с наименьшей суммой элементов. 
// Метод принимает двумерный массив целых чисел matrix и возвращает массив из двух элементов: 
// номер строки с наименьшей суммой (нумерация начинается с 0) и саму сумму.

void prntlist(int[] list) // Вывод елементов массива
{
    for(int i = 0; i < list.Length; i++)
    {
        Console.Write(list[i] + " ");
    }
}
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

int SumOfRow(int[,] matrix, int row) // подсчет суммы элементов в строке массива
{
    int sumElement = 0;
    int len = matrix.GetLength(row);
    int[] newRow = new int[len];
    for(int i = 0; i < len; i++)
    {
        newRow[i] = matrix[row, i];
    }
    for(int i = 0; i < len; i++)
    {
        sumElement += newRow[i];
    }
    return sumElement;
}

int[] MinimumSumRow(int[,] matrix) // поиск индекса с минимальной суммой элементов и минимальной суммы элементов
{
    int sum = 1000;
    int index = 0;
    int[] list = new int[2];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        int count = 0;
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            count += matrix[i,j];
        }
        if(count < sum)
            {
                sum = count;
                index = i;
            }
    }
    list[0] = sum;
    list[1] = index;
    return list;
}


int[,] matrix = new int[,] {
                {5, 2, 6},
                {9, 1, 4},
                {6, 7, 11}
            };
PrintMatrix(matrix);
Console.WriteLine();
int[] a = MinimumSumRow(matrix);
int b = SumOfRow(matrix, a[1]);

prntlist(a);
Console.WriteLine(b);
