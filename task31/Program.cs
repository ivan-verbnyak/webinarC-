/*Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка 
[-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
сумма отрицательных равна -20.
*/

int negative = 0, positive = 0;
int[] arrayResult = new int[12];
int[] GetArray()
{
    int[] array = new int[12];
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 10);
    return array;
}

void SumArray(int[] array)
{
    foreach (int el in array)
    {
        if (el > 0)
        positive += el;
        else negative += el;
    }
    Console.WriteLine(negative + " " + positive);
}

void PrintResult(int[] array, int positive, int negative)
{
    Console.WriteLine($"Array result is {String.Join("|", array)}");
    Console.WriteLine($"Positive sum is {positive} and Negative sum is {negative}");
}

arrayResult = GetArray();
SumArray(arrayResult);
PrintResult(arrayResult, positive, negative);