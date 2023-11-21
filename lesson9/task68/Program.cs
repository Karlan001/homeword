// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int akkerman(int firstNum, int secondNum)
{
    if(firstNum == 0)
    {
        return secondNum + 1;
    }
    else
    {
        if ((firstNum != 0) && (secondNum == 0))
        {
            return akkerman(firstNum - 1, 1);
        }
        else return akkerman(firstNum - 1, (akkerman(firstNum, secondNum - 1)));
    }
}

Console.WriteLine("Введите первое число");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int N = int.Parse(Console.ReadLine());
int result = akkerman(M,N);
Console.WriteLine(result);