// See https://aka.ms/new-console-template for more information
Console.WriteLine("input number");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

for (int i = 0; i <= number; i++)
{
    System.Console.WriteLine(i * i);
}
