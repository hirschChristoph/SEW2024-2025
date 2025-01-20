int[] numbers = new int[5];
Console.WriteLine("Bitte 5 Zahlen eingeben:");

for (int i = 0; i < 5; i++)
{
    numbers[i] = int.Parse(Console.ReadLine());
}

int minNegative = 0;
int maxPositive = 0;
bool hasNegative = false;
bool hasPositive = false;

foreach (int number in numbers)
{
    if (number < 0)
    {
        if (!hasNegative || number < minNegative)
        {
            minNegative = number;
            hasNegative = true;
        }
    }
    else if (number > 0)
    {
        if (!hasPositive || number > maxPositive)
        {
            maxPositive = number;
            hasPositive = true;
        }
    }
}

Console.WriteLine($"Minimum: {minNegative}, Maximum: {maxPositive}");
