// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// Задача 49: Задайте двумерный массив. Найдите элементы, 
// у которых оба индекса чётные, и замените эти элементы на их 
// квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

Console.Clear();
Console.WriteLine("1 - Task48.\n \n2 - Task49\n \n3 - Task51\n \n4 - Task44\n \n5 - Task45");

int numberOfTask = Prompt("Enter the issue number:");
switch (numberOfTask)
            {
                case 1:
                Console.Clear();
                Task48();
                break;

                case 2:
                Console.Clear();
                Task49();
                break;

                case 3:
                Console.Clear();
                Task51();
                break;

                // case 4:
                // Console.Clear();
                // Task44();
                // break;

                // case 5:
                // Console.Clear();
                // Task45();
                // break;

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

static void Task48()
{
    int[,] arr = new int [3, 4];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = i+j;
            Console.Write(arr[i, j]+ " ");
        }
        Console.WriteLine();
    }
}

static void Task49()
    
{
    int[,] array = new int[new Random().Next(2, 10), new Random().Next(2, 10)];
    
    void FilArray(int[,] array)
    {
        
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

    void Explorer(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if(i % 2 == 0 && j % 2 == 0)
                {
                    array[i, j] *= array[i, j];
                }
                Console.Write(array[i,j] + " ");
            }
            Console.WriteLine();
        }
    }

    FilArray(array);
    Console.WriteLine();
    Explorer(array);
}

static void Task51()
{
    int[,] array = new int[5, 5];
    
    void FilArray(int[,] array)
    {
        
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

    void Explorer(int[,] array)
    {
        int Sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if(i == j)
                {
                   Sum += array[i, j];
                }
                
            }
        }
        Console.WriteLine(Sum);
    }

    FilArray(array);
    Console.WriteLine();
    Explorer(array);
}