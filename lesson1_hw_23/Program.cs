// Homework for lesson 3, #23
Console.WriteLine("Enter the number");
int num = int.Parse(Console.ReadLine());
for (int i = 1; i < num + 1; i++)
{
    if (i < num)
    {
        Console.Write(Math.Pow(i, 3) + ", ");
    }
    Console.Write(Math.Pow(i, 3));
}