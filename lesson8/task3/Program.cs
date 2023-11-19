

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

void MultiplyIfPossible(int[,] matrixA, int[,] matrixB)
{
    if(matrixA.GetLength(1) != matrixB.GetLength(0))
    {
        Console.WriteLine("It is impossible to multiply.");
    }
    else
    {
        int[,] newMat = MatrixMultiplication(matrixA, matrixB);
        PrintMatrix(newMat);
    }
}

int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
{
    int[,] newMatrix = new int[matrixA.GetLength(0),matrixB.GetLength(1)];
    for(int i = 0; i < matrixA.GetLength(0); i++)
    {
        for(int j = 0; j < matrixA.GetLength(1); j++)
        {
            for(int k = 0; k < matrixA.GetLength(1); k++)
            {
            newMatrix[i,j] += matrixA[i,k] * matrixB[k,j];
            }
        }
    }
    return newMatrix;
}

int[,] matrixA = new int[,] {
                {2, 4},
                {1, 3},
                {5, 6}
            };

int[,] matrixB = new int[,] {
                {5, 6},
                {7, 8}
            };
PrintMatrix(matrixA);
Console.WriteLine();
PrintMatrix(matrixB);
Console.WriteLine();
MultiplyIfPossible(matrixA, matrixB);
