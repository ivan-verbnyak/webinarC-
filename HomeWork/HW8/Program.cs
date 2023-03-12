Console.Clear();
Console.WriteLine("1 - Task54.\n \n2 - Task56\n \n3 - Task58\n \n4 - Task60\n \n5 - Task62");

int numberOfTask = Prompt("Enter the issue number:");
switch (numberOfTask)
            {
                case 1:
                Console.Clear();
                Task54();
                break;

                case 2:
                Console.Clear();
                Task56();
                break;

                case 3:
                Console.Clear();
                Task58();
                break;

                case 4:
                Console.WriteLine();
                Task60();
                break;

                case 5:
                Console.WriteLine();
                Task62();
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

int[,] NonrepeatingArray()
{
    int a = Prompt("Enter the number of rows in the array: ");
    int b = Prompt("Enter the number of columns in the array: ");
    int[,] array = new int[a,b];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
            Console.Write(array[i, j] + " ");
        }
    }
    return array;
}

//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

void Task54()
{

    int[,] array = NonrepeatingArray();
    Console.WriteLine("\n");
    ArangeArray(array); 


    void ArangeArray(int[,] array)

    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1) - 1; j++)
            {
                for (int k = j + 1; k < array.GetLength(1); k++)
                {
                    if (array[i, k] > array[i, j])
                    {
                        int tmp = array[i, k];
                        array[i, k] = array[i, j];
                        array[i, j] = tmp;
                    }
                }
            }
        }
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}


 
//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

//Например, задан массив:

//1 4 7 2

//5 9 2 3

//8 4 2 4

//5 2 6 7

//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void Task56()
{

    int[,] array = NonrepeatingArray();
    Console.WriteLine();

    int minSum = int.MaxValue;
    int minIndex = -1;
    int sum = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (sum < minSum)
        {
            minSum = sum;
            minIndex = i;
        }
    }
    
    Console.WriteLine($"the smallest sum of elements in a row № {minIndex+1}");
}
 
 
 //Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

void Task58()
{

int[,] Decision(int[,] matrix1, int[,] matrix2)
{
    int[,] m = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
 
    for (int i = 0; i < matrix1.GetLength(0); ++i)
    {
        for (int j = 0; j < matrix2.GetLength(0); ++j)
        {
            for (int k = 0; k < matrix2.GetLength(1); ++k)
            {
                m[i, k] += matrix1[i, j] * matrix2[j, k];
            }
        }
    }
    return m;
}

void TesarrayOutput1()
{
    int[,] matrix1 = 
    {
        {5, 2}, 
        {3, 1}
    };
    int[,] matrix2 =
    {
        {6, 4},
        {9, 2}
    };
 
    int[,] m = Decision(matrix1, matrix2);
 
    for (int i = 0; i < matrix1.GetLength(0); ++i)
    {
        for (int j = 0; j < matrix2.GetLength(1); ++j)
        {
            Console.Write(m[i, j] + " ");
        }
            Console.WriteLine();
    }
        }
 
    TesarrayOutput1();
}

//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)

void Task60()
{

    int[,,] array = new int[2,2,2];
    Random arr = new Random();

    int[,,] NonrepeatingArray()
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.WriteLine();
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.WriteLine();
                for (int k = 0; k < array.GetLength(2); k++)
            
                array[i, j, k] = arr.Next(10, 100);             
            }
        }

        return array;
    }

    void PrintArray(int[,,]array)
    {

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write(array[i, j, k] + "(" + i + "," + j + "," + k + ") ");
            }
            Console.WriteLine();
        }
    }
    }

    array = NonrepeatingArray();
    PrintArray(array);
}


//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07

void Task62()
{

    int[,] array = new int[4, 4];

    void Snail(int[,] array)
    {
        const int n = 4;
        int x = 0, y = 0, dx = 1, dy = 0;

        for (int i = 1; i <= n * n; i++)
        {
            array[x, y] = i;
            int nx = x + dx;
            int ny = y + dy;
            if (nx < 0 || nx >= n || ny < 0 || ny >= n || array[nx, ny] != 0)
            {
                int temp = dx;
                dx = -dy;
                dy = temp;
            }
            x += dx;
            y += dy;
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0,2} ", array[i, j]);
            }
            Console.WriteLine();
        }
    }


    Snail(array);
}
