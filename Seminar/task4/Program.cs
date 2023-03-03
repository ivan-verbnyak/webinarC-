// See https://aka.ms/new-console-template for more information
Console.WriteLine("Input number: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a / 100 == 0 || a / 100 > 9)
{
    Console.WriteLine("this number is correct");
}
else 
{
    int result = a % 10;
Console.WriteLine(result);
}