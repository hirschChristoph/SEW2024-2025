

Random random = new Random();
DateTime start = DateTime.Now;
int number = random.Next(0, 11);
for (int i = 0; i < 100; i++)
{
    
   
    Console.WriteLine($"Errate die Zahl: ");


    if (int.Parse(Console.ReadLine()) != number)
    {
        Console.WriteLine("Spiel verloren! Falsche Zahl!");
        continue;
    }
    
    else/*  if (int.Parse(Console.ReadLine()) == number)*/
    {
        Console.WriteLine("Spiel gewonnen!");
        DateTime end = DateTime.Now;
        TimeSpan duration = end - start;
        Console.WriteLine($"Du hast {(duration).TotalSeconds:f2}Sekunden und {i + 1} Versuche benötigt");
        return;
    }
    
}


