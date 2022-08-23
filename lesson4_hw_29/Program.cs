// Homework for lesson 4, #29
Console.WriteLine("Enter the array's size");
int arr_size = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the min number");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the max number");
int max = int.Parse(Console.ReadLine());

int[] NewArray(int size, int min_digit, int max_digit)
{
  int[] result = new int[size];

  for (int i = 0; i < size; i++)
  {
    result[i] = new Random().Next(min_digit, max_digit + 1);
  }

  return result;
}

int[] my_arr = NewArray(arr_size, min, max);

void PrintArray(int[] prt_array)
{
    for (int i = 0; i < prt_array.Length; i++)
    {
        Console.Write(prt_array[i] + " ");
    }
}

PrintArray(my_arr);