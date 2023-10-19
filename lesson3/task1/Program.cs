string EnterNumber(string msg)
{
    Console.WriteLine(msg);
    string num = Console.ReadLine();
    return num;
}

string IsPalindrome(string number)
{
    int len = number.Length;
    int num = int.Parse(number);
    if(len == 5)
    {
        // Console.WriteLine("Yes");
        if (num / 10000 == num % 10 && num / 1000 % 10 == num % 100 / 10)
        {
            Console.WriteLine("True");
        }
        else Console.WriteLine("False");

    }
    else{ Console.WriteLine("Число не пятизначное");
    Console.WriteLine("False");
    }
    return "";
}

IsPalindrome(EnterNumber("Enter num"));