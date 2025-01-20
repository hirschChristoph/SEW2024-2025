//Benutzer soll zwei Zahlen eingeben und wir berechnen die Summe
Console.Write("Bitte eine Zahl eingeben:");
string input = Console.ReadLine();
double number1 = double.Parse(input);


Console.Write("Bitte noch eine Zahl eingeben: ");
input = Console.ReadLine();
double number2 = double.Parse(input);


Console.WriteLine("Die Summe ist: " + (number1 + number2));
