// Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.

int enterNumber(string msg)
{
    Console.WriteLine(msg);
    string numb = Console.ReadLine();
    int number;
    number = int.Parse(numb);
    return number;
}

int number = enterNumber("Введите число");

if (number > 99 & number < 1000){
    number = number / 10 % 10;
    Console.WriteLine(number);
}
else Console.WriteLine("Введено не 3х значное число");