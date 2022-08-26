// Homework for lesson 5, #34
Console.WriteLine("Enter the array's size");
int arr_size = int.Parse(Console.ReadLine());
int min = 100;
int max = 999;
int even_numbers = 0;

int[] NewArray(int size, int min_digit, int max_digit)
{
  int[] result = new int[size];

  for (int i = 0; i < size; i++)
  {
    result[i] = new Random().Next(min_digit, max_digit + 1);
  }

  return result;
}

int FindEven(int[] array, int count)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

void PrintArray(int[] prt_array)
{
    for (int i = 0; i < prt_array.Length; i++)
    {
        Console.Write(prt_array[i] + " ");
    }
}

int[] my_arr = NewArray(arr_size, min, max);

PrintArray(my_arr);

even_numbers = FindEven(my_arr, even_numbers);

Console.WriteLine($"In this array count of even number: {even_numbers}");