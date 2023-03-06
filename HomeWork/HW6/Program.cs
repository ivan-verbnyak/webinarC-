// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.WriteLine("1 - Task41\n \n2 - Task43");

static int Prompt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int numberOfTask = Prompt("Enter the issue number:");
switch (numberOfTask)
            {
                case 1:
                Console.Clear();
                Task41();
                break;

                case 2:
                Console.Clear();
                Task43();
                break;

                default:
                Console.WriteLine("The task number was entered incorrectly.");
                break;
            }


static void Task41()
{
    System.Console.WriteLine("Input numbers: ");
    string[] numbers = Console.ReadLine().Split(' ');
    System.Console.WriteLine(numbers);
}

static void Task43()
{
    System.Console.WriteLine(" ");
}