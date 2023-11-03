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

int[] FindNumberByPosition (int [,] matrix, int rowPosition, int columnPosition)
{
  // Введите свое решение ниже
  int[] coord = new int[2];
  if (rowPosition <= matrix.GetLength(0) && columnPosition <= matrix.GetLength(1)){
    coord[0] = rowPosition;
    coord[1] = matrix[rowPosition, columnPosition];
  return coord;
  }
  else{
    coord = new int[1];
    return coord;
  }
}

void PrintCheckIfError (int[] results, int X, int Y)
{
  // Введите свое решение ниже
    if (results.Length > 1){
    Console.WriteLine($"The number in [{X}, {Y}] is {results[1]}");
    }    
    else Console.WriteLine("There is no such index");
}

int[,] array = CreateIncreasingMatrix(5, 4, 2);
PrintArray(array);
PrintCheckIfError(FindNumberByPosition(array, 2, 3), 2, 3);
