// Homework for lesson 5, #38

double[] NewArray(int size, double min_digit, double max_digit)
{
  double[] result = new double[size];

  for (int i = 0; i < size; i++)
  {
    result[i] = new Random().NextDouble() * (max_digit - min_digit) + min_digit;
  }

  return result;
}

void PrintArray(double[] prt_array)
{
    for (int i = 0; i < prt_array.Length; i++)
    {
        Console.Write($"{prt_array[i]:f3} ");
    }
}

double FindMin(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
        }
    }
    return min;
}

double FindMax(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
    }
    return max;
}

Console.WriteLine("Enter the array's size");
int arr_size = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the min number");
double min = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the max number");
double max = double.Parse(Console.ReadLine());
double[] my_arr1 = NewArray(arr_size, min, max);
PrintArray(my_arr1);
double min_num = FindMin(my_arr1);
double max_num = FindMax(my_arr1);
double diff = max_num - min_num;
Console.WriteLine();
Console.WriteLine($"Min nubmber = {min_num:f3}");
Console.WriteLine($"Max nubmber = {max_num:f3}");
Console.WriteLine();
Console.WriteLine($"Max nubmber minus min number = {diff:f3}");
