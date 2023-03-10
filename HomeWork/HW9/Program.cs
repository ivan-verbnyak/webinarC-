Console.Clear();
Console.WriteLine("1 - Task66.\n \n2 - Task68\n \n3 - Task64");

int numberOfTask = Prompt("Enter the issue number:");
switch (numberOfTask)
            {
                case 1:
                Console.Clear();
                Task66();
                break;

                case 2:
                Console.Clear();
                Task68();
                break;

                case 3:
                Console.Clear();
                Task64();
                break;

                default:
                Console.WriteLine("The task number was entered incorrectly.");
                break;
            }

int Prompt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void Task66()
{
    Console.Write(FindSumAllElements(Prompt("Input first number: "), Prompt("Input the last number: ")));
    System.Console.WriteLine();
}

int FindSumAllElements(int firstNum, int secondNum)
{
    if (firstNum == secondNum) return firstNum;
    return firstNum + FindSumAllElements (firstNum + 1, secondNum);
}

void Task68()
{
    Console.WriteLine(A(Prompt("input m: "), Prompt("input n: ")));
}
static int A(int m, int n)
{
  if (m == 0)
    return n + 1;
  else
    if ((m != 0) && (n == 0))
      return A(m - 1, 1);
    else
      return A(m - 1, A(m, n - 1));
}
void Task64()
{
    System.Console.WriteLine();
}

// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29