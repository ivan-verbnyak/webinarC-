Console.Write("enter the coordinates; ");
int[] coordinates = new int [4];
for (int i = 0; i < coordinates.Length; i++)
{
    coordinates[i] = Convert.ToInt32(Console.ReadLine());
}
double distance = Math.Sqrt((coordinates[2]-coordinates[0]) * (coordinates[2]-coordinates[0]) + (coordinates[3]-coordinates[1]) * (coordinates[3]-coordinates[1]));
System.Console.WriteLine(distance);