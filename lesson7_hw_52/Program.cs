// Homework for lesson 7, #52

int[,] CreateArray(int rows, int columns, int min, int max)
{
    int[,] createdArray = new int[rows, columns];

    for (int i = 0; i < createdArray.GetLength(0); i++)
    {
        for (int j = 0; j < createdArray.GetLength(1); j++)
        {
            createdArray[i, j] = new Random().Next(min, max + 1);
        }
    }
    return createdArray;
}

void PrintArray(int[,] arrayForPrint)
{
    for (int i = 0; i < arrayForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayForPrint.GetLength(1); j++)
            Console.Write($"{arrayForPrint[i, j]} ");
        Console.WriteLine();
    }
}

void ArithmeticMean(int[,] arrayForCheck)
{
    int currentColumn = 0;
    for (int j = 0; j < arrayForCheck.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < arrayForCheck.GetLength(0); i++)
            sum += arrayForCheck[i, j];
            currentColumn++;
        double average = sum / arrayForCheck.GetLength(0);
    
        if (currentColumn == arrayForCheck.GetLength(1))
        {
            Console.Write($"{average:f2}"); // for last column
        }
        else
        {
            Console.Write($"{average:f2}, ");
        }
    }
}

Console.Write("Enter minimum number in array: ");
int minNum = int.Parse(Console.ReadLine());
Console.Write("Enter maximum number in array: ");
int maxNum = int.Parse(Console.ReadLine());
Console.Write("Enter the count of rows: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Enter the count of columns: ");
int columns = int.Parse(Console.ReadLine());

Console.WriteLine("Array with random numbers: ");
int[,] createdArray = CreateArray(rows, columns, minNum, maxNum);
PrintArray(createdArray);
Console.WriteLine();
Console.WriteLine("Arithmetic mean of columns in the array: ");
ArithmeticMean(createdArray);