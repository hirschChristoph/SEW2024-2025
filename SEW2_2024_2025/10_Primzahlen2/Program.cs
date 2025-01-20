Console.Write("Enter a number: ");
int limit = int.Parse(Console.ReadLine());

Console.WriteLine($"Prime numbers up to {limit}:");

for (int i = 2; i <= limit; i++)
{
    if (IsPrime(i))
    {
        Console.Write(i + " ");
    }
}
  

    static bool IsPrime(int number)
{
    if (number <= 1) return false;
    if (number == 2) return true;

    for (int i = 2; i <= Math.Sqrt(number); i++)
    {
        if (number % i == 0) return false;
    }

    return true;
}