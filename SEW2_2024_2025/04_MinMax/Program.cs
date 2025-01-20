int[] zahlen = new int[3];

// Eingabe der drei Zahlen
for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Bitte geben Sie eine Zahl ein: ");
    zahlen[i] = int.Parse(Console.ReadLine());
}

// Initialisiere die kleinste und größte Zahl
int min = zahlen[0];
int max = zahlen[0];

// Schleife zur Bestimmung der kleinsten und größten Zahl
for (int i = 1; i < zahlen.Length; i++)
{
    if (zahlen[i] < min)
    {
        min = zahlen[i];
    }
    if (zahlen[i] > max)
    {
        max = zahlen[i];
    }
}

Console.WriteLine("Die kleinste Zahl ist: " + (min) + " und die größte Zahl ist: " + (max));

