int[] points = new int[2];
for (int i = 0; i < points.length; i++)
{
    while (true)
    {
        points[i] = Convert.ToInt32(Console.ReadLine());
        if (points[i] ! = 0)
            break;
        else
            System.Console.WriteLine("Incorrect input");
    }
    
}
if (points[0] > 0 && points[1] > 0)
    System.Console.WriteLine("1");
else if (points[0] < 0 && points[1] > 0)
    System.Console.WriteLine("2");
else if ((points[0] < 0 && points[1] < 0))
    System.Console.WriteLine("3");
else System.Console.WriteLine("4");