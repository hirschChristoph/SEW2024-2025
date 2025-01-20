double[] array = new double[10];

for (int i = 0; i < 5; i++)
{
    Console.Write("Bitte eine Zahl Eingeben: ");
    string input = Console.ReadLine();
    array[i] = double.Parse(input);
}


