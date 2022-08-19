// Homework for lesson 3, #19
Console.WriteLine("Enter the number");
int num = int.Parse(Console.ReadLine());
int reverted = 0;
if (num > 9999 && num < 100000)
{
    for (int i = 0; num > 0; i++)
    {
        reverted *= 10;
        reverted += num % 10;
        num /= 10;
        
    }
    Console.WriteLine(reverted);
}
else
{
    Console.WriteLine("This number isn't a five-digit number");
}