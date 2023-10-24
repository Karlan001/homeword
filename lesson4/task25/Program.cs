// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int GetNumber(string msg)
{
    Console.WriteLine(msg);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int Expon(int num1, int num2)
{
    int result = 1;
    for (int i = 0; i < num2; i++)
    {
        result *= num1;
    }
    return result;
}

int number1 = GetNumber("Введи число");
int number2 = GetNumber("Введи число");

Console.WriteLine(Expon(number1, number2));