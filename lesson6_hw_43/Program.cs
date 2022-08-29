// Homework for lesson 6, #43

void IntersectionPoint(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
        if (k1 == k2)
        {
            Console.Write("There's no intersection of lines");
        }

        else
        {
            Console.Write($"Lines intersection on: {x}; {y}");
        }
    
}

Console.WriteLine("Enter the b1: ");
double b1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the k1: ");
double k1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the b2: ");
double b2 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the k2: ");
double k2 = int.Parse(Console.ReadLine());

IntersectionPoint(b1, k1, b2, k2);