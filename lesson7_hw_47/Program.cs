// Homework for lesson 7, #47

double[,] CreateArray(int rows, int columns, int min, int max)
{
    double[,] createdArray = new double[rows, columns];

    for (int i = 0; i < createdArray.GetLength(0); i++)
    {
        for (int j = 0; j < createdArray.GetLength(1); j++)
        {
            createdArray[i, j] = new Random().Next(min, max + 1);
        }
    }
    return createdArray;
}

void PrintArray(double[,] arrayForPrint)
{
    for (int i = 0; i < arrayForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayForPrint.GetLength(1); j++)
            Console.Write($"{arrayForPrint[i, j]} ");
        Console.WriteLine();
    }
}

Console.Write("Enter the number of rows: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int columns = int.Parse(Console.ReadLine());
Console.Write("Enter minimum of random numbers: ");
int minimum = int.Parse(Console.ReadLine());
Console.Write("Enter maximum of random numbers:  ");
int maximum = int.Parse(Console.ReadLine());
double[,] randomArray = CreateArray(rows, columns, minimum, maximum);
PrintArray(randomArray);