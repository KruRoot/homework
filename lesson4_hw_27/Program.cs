// Homework for lesson 4, #27
Console.WriteLine("Enter the number");
int num = int.Parse(Console.ReadLine());

int sum_num(int number)
{
    int res = 0;
    for (int i = 0; number > 0; i++)
    {
        res += number % 10;
        number /= 10;
    }
    return res;
}

Console.WriteLine(sum_num(num));