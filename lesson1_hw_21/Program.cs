// Homework for lesson 3, #21
Console.WriteLine("Enter the coordinates of point x1: ");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the coordinates of point y1: ");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the coordinates of point z1: ");
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the coordinates of point x2: ");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the coordinates of point y2: ");
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the coordinates of point z2: ");
int z2 = int.Parse(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(x2 - x2, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine($"Distance between two points in 3D: {distance:f2}");