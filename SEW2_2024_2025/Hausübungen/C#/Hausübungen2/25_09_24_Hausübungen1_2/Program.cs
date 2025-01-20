Console.WriteLine("Bitte ein druckbares Zeichen eingeben:");
char symbol = Console.ReadLine()[0];

int[] numbers = new int[5];
Console.WriteLine("Bitte 5 ganze Zahlen (1 bis 10) eingeben:");
for (int i = 0; i < 5; i++)
{
    numbers[i] = int.Parse(Console.ReadLine());
}

int maxNumber = 10; // Da die Zahlen im Bereich von 1 bis 10 liegen

for (int i = maxNumber; i > 0; i--)
{
    for (int j = 0; j < 5; j++)
    {
        if (numbers[j] >= i)
        {
            Console.Write(symbol + " ");
        }
        else
        {
            Console.Write("  ");
        }
    }
    Console.WriteLine();
}