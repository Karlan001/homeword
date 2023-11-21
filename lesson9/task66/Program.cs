// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int sum = 0;

int sumElement(int firstNum, int secondNum)
{
    if(firstNum > secondNum)
    {
        return firstNum;
    }
    else
    {
        sumElement(firstNum + 1, secondNum);
        sum += firstNum;
        return sum;
    }
    return sum;
}


Console.WriteLine("Введите первое число");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int N = int.Parse(Console.ReadLine());
if (M > N)
{
    Console.WriteLine("Первое веденное число больше второго");
}
else
{
int total = sumElement(M, N);
Console.WriteLine(total);
}

