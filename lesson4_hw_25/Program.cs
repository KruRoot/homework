// Homework for lesson 4, #25
Console.WriteLine("Enter the first number");
int first_num = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the second number");
int second_num = int.Parse(Console.ReadLine());

double exponentiation(int num, int degree)
{
    double res = Math.Pow(num, degree);
    return res;
}

Console.WriteLine(exponentiation(first_num, second_num));