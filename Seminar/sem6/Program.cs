/*Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10 */


Console.Clear();
Console.WriteLine("1 - Task39.\n \n2 - Task40\n \n3 - Task42");

int numberOfTask = Prompt("Enter the issue number:");
switch (numberOfTask)
            {
                case 1:
                Console.Clear();
                Task39();
                break;

                case 2:
                Console.Clear();
                Task40();
                break;

                case 3:
                Console.Clear();
                Task42();
                break;

                default:
                Console.WriteLine("The task number was entered incorrectly.");
                break;
            }

static int Prompt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

static void Task39()
{
    int[] GenerateArray(int length)
    {
        int[] array = new int[length];
        for (int i = 0; i < length; i++)
        array[i] = new Random().Next(-10, 11);
        return array;
    }

    int[] ReverseArray(int[] array)
    {
        for (int i = 0; i < array.Length / 2; i++)
        {
            int tmp = array[i];
            array[i] = array[array.Length - 1 - i];
            array[array.Length - 1 - i] = tmp;
        }
    return array;
    }

    int[] AnotherReverseArray(int[] array)
    {
        int[] tmpArray = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        tmpArray[i] = array[array.Length - 1 - i];
        return tmpArray;
    }

    void PrintArray(int[] array)
    {
        Console.WriteLine(String.Join(" ", array));
    }

    int[] array = GenerateArray(10);
    PrintArray(array);
    PrintArray(AnotherReverseArray(array));
    PrintArray(ReverseArray(array));
}

static void Task40()
{
    Console.WriteLine("Examination of true triangle.");
    
    Console.Write("Write side a: ");
    int a = Convert.ToInt32(Console.ReadLine());

    Console.Write("Write side b: ");
    int b = Convert.ToInt32(Console.ReadLine());

    Console.Write("Write side c: ");
    int c = Convert.ToInt32(Console.ReadLine());

    if (a + b > c && a + c > b && b + c > a)
    {
        Console.WriteLine("Exam for triangle was passed!");
    }
    else
    {
        Console.WriteLine("Exam for triangle was failed!");
    }
}

static void Task42()
{
    Console.Write("Enter a number: ");
    int dec = int.Parse(Console.ReadLine());

    string bin = "";

    while (dec > 0)
    {
        bin = (dec % 2).ToString() + bin;
        dec /= 2;
    }

    Console.WriteLine("Binary: {0}", bin);
}