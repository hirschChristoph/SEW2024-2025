Console.Write("Geben Sie eine Zahl ein: ");
int number = int.Parse(Console.ReadLine());

bool isPrime = true;

if (number <= 1)
{
    isPrime = false;
}
else if (number == 2)
{
    isPrime = true;
}
else
{
    for (int i = 2; i * i <= number; i++)
    {
        if (number % i == 0)
        {
            isPrime = false;
            break;
        }
    }
}

if (isPrime)
{
    Console.WriteLine($"{number} ist eine Primzahl.");
}
else
{
    Console.WriteLine($"{number} ist keine Primzahl.");
}
       