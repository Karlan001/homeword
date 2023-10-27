// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] createArray(string msg) // Создаем массив.
{
    Console.WriteLine(msg);
    int length = int.Parse(Console.ReadLine());
    int[] array = new int[length];
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

int checkArray(int[] checkArr) // Проверяем количество введенных больше 0 цифр.
{
    int count = 0;
    for (int i = 0; i < checkArr.Length; i++)
    {
        if(checkArr[i] > 0 )
        {
             count ++;
        }
    }
    return count;
}

int[] FillingArray(int[] filArr) // Заполняем созданный массив с помощью ввода с клавиатуры
{
    for (int i = 0; i < filArr.Length; i++)
    {
        int number = int.Parse(Console.ReadLine());
        filArr[i] = number;
    }
    return filArr;
}


int[] emptyArray = createArray("Введи количество цифр, которое будем проверять");
Console.WriteLine("Введи цифры по одной на каждой строке");
int[] filArray = FillingArray(emptyArray);
printArray(filArray);
Console.Write("Колличество чисел больше 0 равно ");
Console.Write(checkArray(filArray));


