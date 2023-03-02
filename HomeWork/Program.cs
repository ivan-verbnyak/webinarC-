/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2

Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0

Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */

Console.Clear();
Console.WriteLine("1 - Task34.\n \n2 - Task36\n \n3 - Task38");

int numberOfTask = Prompt("Enter the issue number:");
switch (numberOfTask)
            {
                case 1:
                Console.Clear();
                Task34();
                break;

                case 2:
                Console.Clear();
                Task36();
                break;

                case 3:
                Console.Clear();
                Task38();
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

static void Task34()
{
    int[] arr = new int[8];
    Random random = new Random();
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(100, 1000);
        Console.Write($"{arr[i]}\t");
    }
    Console.WriteLine();

   for (int j = 0; j < arr.Length; j++)
   {
        if (arr[j] % 2 == 0)
        {
            count++;
        }
   }
    Console.WriteLine($"the number of even numbers in the array: {count}");
}

static void Task36()
{
    int[] arr = new int[8];
    Random random = new Random();
    int sum = 0, j = 1;
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(-10, 11);
        Console.Write($"{arr[i]}\t");
    }
    Console.WriteLine();

    
    while (j < arr.Length)
    {
        sum += arr[j];
        j = j + 2;
    }
    Console.WriteLine($"The sum of the elements in odd positions in the array {sum}");
}

static void Task38()
{
    Console.WriteLine("set the array");
    int[] arr = new int[5];
    int max = int.MinValue, min = int.MaxValue, diff = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }

    for (int j = 0; j < arr.Length; j++)
    {
        if (max < arr[j])
        {
            max = arr[j];
        }
        else if (min > arr[j])
        {
            min = arr[j];
        }
    }
    diff = (max - min);
    Console.WriteLine($"the difference between the maximum and minimum values {diff}");
}