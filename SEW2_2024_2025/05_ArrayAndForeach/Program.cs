int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9,10};

Console.WriteLine(numbers[0]);
numbers[0] = 100;
Console.WriteLine(numbers[0]);

Console.WriteLine("- - - - - - - - - - - -");
for(int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}

Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
foreach(int rdmvar in numbers)
{
    Console.WriteLine(rdmvar);
}

double price = 9.99;
int age = 16;
string article = "Edelweiss Hofbräu";

Console.WriteLine($"Ein {article} darf mit {age} Jahren um {price} erworben werden.");
Console.WriteLine($"Die erste Zahl lautet {numbers[0]} und die Summe lautet {numbers.Sum()}");
