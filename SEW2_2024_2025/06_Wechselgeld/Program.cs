double budget;
Console.WriteLine("Bitte geben Sie ihr Budget ein: ");
budget = double.Parse(Console.ReadLine());
int anzahl;

int[] scheine = { 500, 200, 100, 50, 20, 10, 5, 2, 1};
double[] muenzen = {0.5, 0.2, 0.1, 0.05, 0.02, 0.01 };

foreach (int schein in scheine)
{
    anzahl = (int)(budget / schein);
    if (anzahl != 0)
    {
        Console.WriteLine($"{anzahl}x{schein} Euro");
    }
    budget %= schein;
}

foreach (double muenze in muenzen)
{
    anzahl = (int)(budget / muenze);
    if (anzahl != 0)
    {
        Console.WriteLine($"{anzahl}x{muenze * 100}cent");
    }
    budget %= muenze;
}