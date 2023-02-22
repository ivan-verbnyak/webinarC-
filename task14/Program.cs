int GetNumber()
{
    Console.WriteLine("Input number:");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int Numbers()
{
    int a = GetNumber();
    int count = 0;
    while (a >0)
    {
        a = a / 10;
        count ++;
    }
    return count;
}

int Result()
{
    int b = GetNumber();
    int x = 1;
    for (int i = 1; i <= b; i++)
    {
        x = x*i;
    }
    return x;
}

Console.WriteLine(Result());