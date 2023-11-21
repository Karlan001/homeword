// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа
// в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

void NatureNum(int firstNum, int secondNum)
{
    if (firstNum > secondNum)
    {
        return;
    }
    if (firstNum % 2 == 0)
    {
        Console.Write(firstNum + ",");
        NatureNum(firstNum+2, secondNum);
    }
    else
    {
        firstNum += 1;
        NatureNum(firstNum, secondNum);
    }
}


Console.WriteLine("Введите первое число");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int N = int.Parse(Console.ReadLine());
if (M > N)
{
    Console.WriteLine("Первое веденное число больше второго");
}
else NatureNum(M, N);