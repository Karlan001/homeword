// // Внутри класса Answer напишите метод CreateRandomMatrix, который принимал бы числа m и n (размерность массива),
// // а также minLimitRandom и maxLimitRandom, которые указывают на минимальную и максимальную границы случайных чисел.

// // Также, задайте метод PrintArray, который выводил бы массив на экран.

// // Для вывода матрица используйте интерполяцию строк для форматирования числа matrix[i, j]
// // с двумя знаками после запятой (f2) и добавления символа табуляции (\t) после каждого элемента матрицы.
// // Таким образом, каждый элемент матрицы будет разделен символом табуляции при выводе.

double[,] generateArray(int countCollums, int countLine, int minLimitRandom, int maxLimitRandom) // Генерируем двумерный массив и заполняем случайными числами
{
    double[,] array = new double[countCollums, countLine]; // Создание матрицы 
    Random random = new Random(); 
    for (int i = 0; i < countLine; i++)
    {
        for (int m = 0; m < countCollums; m++)
        {
            array[m, i] = random.Next(minLimitRandom, maxLimitRandom) + random.NextDouble();
        }
    }
    return  array;
}

void printMassive(double[,] collection) // Вывод двумерного массива
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int m = 0; m < collection.GetLength(1); m++)
        {
            Console.Write($"{collection[i,m]:f2}\t"); // конвертация строки в вещественное число (string.Format("{0:f}", number))
        }
    }
    Console.WriteLine();
}

double[,] arr = generateArray(3, 4, -10, 10);
printMassive(arr);