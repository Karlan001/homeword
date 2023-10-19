// Внутри класса Answer напишите метод ShowCube, 
// который принимает на вход число (N) и 
// выводит таблицу кубов чисел от 1 до N (включительно) каждое на новой строке.

void ShowCube(int num)
{
    int count = 1;
    while(count <= num)
    {
        int sum = count * count * count;
        Console.WriteLine(sum);
        count++;
    }
}
ShowCube(10);