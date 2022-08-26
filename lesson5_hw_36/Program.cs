// Homework for lesson 5, #36

int[] NewArray(int size, int min_digit, int max_digit)
{
  int[] result = new int[size];

  for (int i = 0; i < size; i++)
  {
    result[i] = new Random().Next(min_digit, max_digit + 1);
  }

  return result;
}

void PrintArray(int[] prt_array)
{
    for (int i = 0; i < prt_array.Length; i++)
    {
        Console.Write(prt_array[i] + " ");
    }
}

int OddPositionsSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

Console.WriteLine("Enter the array's size");
int arr_size = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the min number");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the max number");
int max = int.Parse(Console.ReadLine());
int[] my_arr1 = NewArray(arr_size, min, max);
PrintArray(my_arr1);
int OddSum = OddPositionsSum(my_arr1);
Console.WriteLine();
Console.WriteLine($"In this array sum of numbers on odd positions: {OddSum}");