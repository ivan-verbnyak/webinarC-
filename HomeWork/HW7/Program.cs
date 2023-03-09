// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
Console.WriteLine("1 - Task47.\n \n2 - Task50\n \n3 - Task52");

int numberOfTask = Prompt("Enter the issue number:");
switch (numberOfTask)
            {
                case 1:
                Console.Clear();
                Task47();
                break;

                case 2:
                Console.Clear();
                Task50();
                break;

                case 3:
                Console.Clear();
                Task52();
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

static void Task47()
{
    int[,] array = new int[3, 4];
       
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
            Console.Write(array[i, j]+ " ");
        }
        Console.WriteLine();
    }
}

static void Task50()
{
    int ViewerNumber = Prompt("Input number: ");
    int[,] array = new int[new Random().Next(7, 10), new Random().Next(7, 10)];
    
    void FilArray(int[,] array)
    {
        
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = new Random().Next(0, 100);
                Console.Write(array[i, j]+ " ");
            }
            Console.WriteLine();
        }
    }
    void Viewer(int[,] array, int ViewerNumber)
    {
        int count = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {                            
                if (array[i,j] == ViewerNumber)
                {
                     Console.WriteLine($"The desired element is in position: {i}, {j}");
                }
                else count++;
            }
        }
        if (count == array.GetLength(0) * array.GetLength(1))
        {
            System.Console.WriteLine("this element is not present");
        }

    }
    FilArray(array);
    Console.WriteLine();
    Viewer(array, ViewerNumber);
}

static void Task52()
{
    int[,] arr = new int[3,4]
    {
        {1, 4, 7, 2},
        {5, 9, 2, 3},
        {8, 4, 2, 4},
    };
        
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        float Sum = 0;    
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Sum += arr[i,j];
        }
        Console.Write(Sum / arr.GetLength(1) + " ");
    }
    System.Console.WriteLine();

}