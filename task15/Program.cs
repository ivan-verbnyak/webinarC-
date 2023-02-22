/*Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]

Random random = new Random();
int[] mArray = new int[8];

for (int i = 0; i < mArray.Length; i++)
{
    mArray[i] = random.Next(0, 2)
}
string array = string.Join("_", mArray);

System.Console.WriteLine(array);
*/
Random random = new Random();
int [] arr = new int [8];

for (int i = 0; i < arr.Length; i++)
{
    arr [i] = random.Next(0,2);
    //Console.Write(arr[i] + " ");
}
string array = String.Join("_", arr);
Console.WriteLine(array);