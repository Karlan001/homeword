// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetNumber(string msg)
{
    Console.WriteLine(msg);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int SumDigit(int num)
{
    int result = 0;
    while(num > 0)
    {
        result += num % 10;
        num /= 10;
    }
    return result;
}

int number = GetNumber("Введи число");
Console.WriteLine(SumDigit(number));