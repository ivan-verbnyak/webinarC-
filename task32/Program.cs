/*Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
*/

int[] array = new int[8];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-10, 11);
    System.Console.Write($"{array[i]}\t");
}
System.Console.WriteLine();
for (int i = 0; i < array.Length; i++)
{
    array[i] *= -1;
    System.Console.Write($"{array[i]}\t");
}
System.Console.WriteLine();