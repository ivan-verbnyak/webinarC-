//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Input number: ");

int number = Convert.ToInt32(Console.ReadLine());

if ( number % 2 == 0 )
{
    number = Console.WriteLine("even");
}
else
{
    Console.WriteLine("odd");
}