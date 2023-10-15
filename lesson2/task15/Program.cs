// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

int enterNumber(string msg)
{
    Console.WriteLine(msg);
    string numb = Console.ReadLine();
    int number;
    number = int.Parse(numb);
    return number;
}

int number = enterNumber("Ведите число от 1 до 7");
if (number > 0 & number < 6){
    Console.WriteLine("Будний день");
}
if (number > 5 & number < 8){
    Console.WriteLine("Выходной");
}
if (number < 1 || number > 7){
    Console.WriteLine("Введеное число не в рамках 1-7");
}