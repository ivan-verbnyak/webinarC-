System.Console.WriteLine("input first numbers: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("input the numbers: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a % b == 0 ) System.Console.WriteLine("the number is a multiple");
else System.Console.WriteLine($"remains {a%b}");