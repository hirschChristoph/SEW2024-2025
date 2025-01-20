

using _24_ReactionTime;

Random random = new Random();
Stopwatch watch = new Stopwatch();
//DateTime start = DateTime.Now;
for (int i = 0; i < 10;i++)
{
    int number = random.Next(0, 26);
    char letter = (char)('a' + number);         //ascii vom 'a' + Zufallszahl
    Console.WriteLine(letter);
    ConsoleKeyInfo keyInfo = Console.ReadKey();
    Console.WriteLine();
    if (keyInfo.KeyChar != letter)
    {
        Console.WriteLine("Spiel verloren! Falsche Taste!");
        return;
    }
}
//DateTime end = DateTime.Now;
TimeSpan elapsed = watch.Elapsed();
Console.WriteLine($"Zeit: {(elapsed).TotalSeconds:f2}");



