System.Console.WriteLine("input first numbers: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("input the numbers: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a == b * b) System.Console.WriteLine($"{a} is the squsre of {b}");
else if (b == a * a) System.Console.WriteLine($"{b} is the squsre of {a}");
else System.Console.WriteLine($"no squsres");