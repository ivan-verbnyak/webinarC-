// See https://aka.ms/new-console-template for more information
Console.WriteLine("input numbers from 1 before 4");

int number = Convert.ToInt32(Console.ReadLine());

switch (number)
{
    case 1: System.Console.WriteLine("X > 0, Y > 0");
    break;
    case 2: System.Console.WriteLine("X < 0, Y > 0");
    break;
    case 3: System.Console.WriteLine("X > 0, Y < 0");
    break;
    case 4: System.Console.WriteLine("X < 0, Y < 0");
    break;
    default: System.Console.WriteLine("does not exit");
    break;
}