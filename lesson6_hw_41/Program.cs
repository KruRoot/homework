// Homework for lesson 6, #41

int FindPositiveNumbers(int[] arrayForSearch)
{
    int positiveNumbers = 0;
    for (int i = 0; i < arrayForSearch.Length; i++)
    {
        if (arrayForSearch[i] > 0)
        {
            positiveNumbers++;
        }
    }
    return positiveNumbers;
}

Console.WriteLine("Enter the numbers (separated by space): ");
int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
int positiveNumbers = FindPositiveNumbers(numbers);
Console.WriteLine($"Positive numbers: {positiveNumbers}");