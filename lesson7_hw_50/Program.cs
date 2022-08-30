// Homework for lesson 7, #50

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

bool CheckExistElement(int[,] arrayForCheck, int rowPosition, int columnPosition)
{
    if (rowPosition <= arrayForCheck.GetLength(0) && columnPosition <= arrayForCheck.GetLength(1))
    {
        return true;
    }
    return false;
}

Console.Write("Enter minimum number in array: ");
int minNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter maximum number in array: ");
int maxNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the count of rows: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Enter the count of columns: ");
int columns = int.Parse(Console.ReadLine());
Console.Write("Enter the array position in rows: ");
int rowPosition = int.Parse(Console.ReadLine());
Console.Write("Enter the array position in columns: ");
int columnPosition = int.Parse(Console.ReadLine());
Console.WriteLine("Array with random numbers: ");
int[,] createdArray = CreateArray(rows, columns, minNum, maxNum);
PrintArray(createdArray);
Console.WriteLine();
if (CheckExistElement(createdArray, rowPosition, columnPosition) == false)
{
    Console.WriteLine($"Array element on position " +
    $"rows: {rowPosition}, columns: {columnPosition} doesn't exist!");
}
else
{
    Console.Write($"Array element on position " +
    $"rows: {rowPosition}, columns: {columnPosition} = " +
    createdArray[rowPosition - 1, columnPosition - 1]); // Count from 1 cuz user will count array from 1
}