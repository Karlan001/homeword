// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int[] createArray(string msg) // Создаем массив и заполняем массив.
{
    Console.WriteLine(msg);
    int[] array = new int[4];
    int count = 1;
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введи {count} число");
        count ++;
        int number = int.Parse(Console.ReadLine());
        array[i] = number;
    }
    return array;

}

void printArray(int[] arr) // Выводим массив на печать.
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}\t");
    }
    Console.WriteLine();
}

bool dotCross(double num1, double num2) // Проврка на одинаковый результат
{
    if (num1 == num2)
    {
        return true;
    }
    else return false;
}

(double, double) calculate(int[] array) // Подсчет координат и возврат 2 переменных
{
    double numX = (array[2] - array[3]) / (array[0] - array[1]);
    double num1 = array[0] * numX + array[2];
    double num2 = array[1] * numX + array[3];
    return (num1, num2);
}

int[] array = createArray("Введи 4 координаты");
printArray(array);
(double cord1, double cord2) = calculate(array); // Запись двух переменных из функции 
Console.WriteLine(calculate(array));
if (dotCross(cord1, cord2))
{
    Console.WriteLine($"Прямые пересекаются в точке {calculate(array)}");
}
else Console.WriteLine("Прямые не пересекаются");
