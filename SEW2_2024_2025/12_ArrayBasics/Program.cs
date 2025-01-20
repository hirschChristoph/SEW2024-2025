int[] number = new int[5];
for (int i = 0; i < 5; i++)
{
    Console.Write("Bitte eine Zahl Eingeben: ");
    string input = Console.ReadLine();
    number[i] = int.Parse(input);
}

foreach(int num in number)
{
    Console.WriteLine(num);
}

Array.Sort(number);

foreach (int num in number)
{
    Console.WriteLine(num);
}

Console.WriteLine($"Größte Zahl: {number.Max()}");
Console.WriteLine($"Kleinste Zahl: {number.Min()}");
Console.WriteLine($"Summe: {number.Sum()}");
Console.WriteLine($"Mittelwert: {number.Average()}");
Console.WriteLine($"Mittelwert: {number.Sum() / number.Length}");