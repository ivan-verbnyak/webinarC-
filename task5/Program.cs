Random number = new Random();
int numb = number.Next(100, 1000);
int a = numb / 100;
int b = numb % 10;
System.Console.WriteLine($"{a}, {b}, {numb}");