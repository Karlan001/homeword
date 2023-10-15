// Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

int enterNumber(string msg)
{
    Console.WriteLine(msg);
    string numb = Console.ReadLine();
    int number;
    number = int.Parse(numb);
    return number;
}

int examination(int num){
    if (num > 99 & num < 999){
        num = num % 10;
        Console.WriteLine(num);
    }
    else if (num > 999 & num < 9999){
        num = num / 10 % 10;
        Console.WriteLine(num);
    }
    else if (num > 9999){
        num = num / 100 % 10;
        Console.WriteLine(num);
    }
    else Console.WriteLine("Третьей цифры нет");
    return num;
}

int number = enterNumber("Введите число");
int exam = examination(number);