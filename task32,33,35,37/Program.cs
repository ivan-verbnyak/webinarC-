/* Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, -3] -> да 

Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5

Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/
Console.Clear();
Console.WriteLine("1 - Программа для замены положительного на отрицательный знак и наоборот.");
Console.WriteLine("2 - Программа для поиска заданного числа в массиве.");
Console.WriteLine("3 - Task_35");
Console.WriteLine("4 - Task_37");
int numberOfTask = Prompt("Введите номер задачи: ");
switch (numberOfTask)
            {
                case 1:
                Console.Clear();
                Task_32();
                break;

                case 2:
                Console.Clear();
                Task_33();
                break;

                case 3:
                Console.Clear();
                Task_35();
                break;

                case 4:
                Console.Clear();
                Task_37();
                break;

                default:
                Console.WriteLine("Номер задачи введен некорректно.");
                break;
            }

static int Prompt(string message)// Метод запроса числа.
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

static void Task_32()
{
    int [] arr = new int [8];
    Random random = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(-10, 11);
        Console.Write($"{arr[i]}\t");
    }
    Console.WriteLine();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= -1;
        Console.Write($"{arr[i]}\t");
    }
}

static void Task_33()
{
    int[] arr = new int[8];
    Random rand = new Random();
    for (int j = 0; j < arr.Length; j++)
    {
        arr[j] = rand.Next(-10, 11);
        Console.Write($"{arr[j]}\t");
    }
    int number = Prompt("\nВведите число для поиска: ");

    if(FoundNumberOfArray(arr, number, out int i))
    {
        Console.WriteLine($"Элемент {number} найден под индексом {i}.");
    }
    else
    {
        Console.WriteLine($"Элемент {number} не найден.");
    }   
    
}

static bool FoundNumberOfArray(int [] arr, int userNumber, out int i)
{
    for (i = 0; i < arr.Length; i++)
    {
        if (arr[i] == userNumber)
        {
            return true; 
        }        
    }
    return false;
}

static void Task_35()
{
    int[] arr = new int[123];
    Random rand = new Random();
    int count = 0;
    for (int j = 0; j < arr.Length; j++)
    {
        arr[j] = rand.Next(-10, 500);
        Console.Write($"{arr[j]}\t");
        if(arr[j] >= 10 && arr[j] <100)
        {
            count++;
        }        
    }
    
    System.Console.WriteLine();
    System.Console.WriteLine($"Колличество элементов в диапазоне от 10 до 99 = {count}");

}

static void Task_37()
{
    int[] arr = new int[8];
    int[] arr2;
    Random rand = new Random();
    
    for (int j = 0; j < arr.Length; j++)
    {
        arr[j] = rand.Next(0, 10);
        Console.Write($"{arr[j]}, ");
    }
    System.Console.WriteLine();
        if (arr.Length % 2 != 0)
    {
        arr2 = new int [arr.Length / 2 + 1];
        arr2 [arr.Length / 2] = arr[arr.Length / 2];
    }
    else
    {
        arr2 = new int [arr.Length / 2];
    }

    for (int i = 0, j = arr.Length - 1; i < arr.Length / 2; i++, j--)
    {
        arr2[i] = arr[i] * arr [j];
    }
    System.Console.Write("произведение пар чисел в одномерном массиве: ");
    foreach (var item in arr2)
    {
        Console.Write(item + ", ");
    }
    System.Console.WriteLine();
}