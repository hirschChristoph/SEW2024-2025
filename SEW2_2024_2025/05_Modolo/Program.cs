int input;
Console.WriteLine("Bitte geben Sie eine Zahl ein: ");
input = int.Parse(Console.ReadLine());



if( input % 3 == 0 && input % 5 == 0)
{
    Console.WriteLine("Die Zahl ist durch 3 und durch 5 teilbar.");
}
else if (input % 3 == 0)
{
    Console.WriteLine("Die Zahl ist durch 3 teilbar.");
}
else if (input % 5 == 0)
{
    Console.WriteLine("Die Zahl ist durch 5 teilbar.");
}
else
{
    Console.WriteLine("Die Zahl ist weder durch 5 noch durch 3 teilbar.");
}