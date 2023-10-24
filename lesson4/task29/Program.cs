// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] GenerateArray(int length = 20)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(200);
    }
    return array;
}
void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}
