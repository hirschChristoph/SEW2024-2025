Console.Write("Bitte eine Dezimalzahl eingeben: ");
string input = Console.ReadLine();
int number = int.Parse(input);


string result = "";
//Schleife, solange durch 2 dividieren bis number == 0
while(number > 0)
{

    int rest = number % 2;  //rest ist entweder 0 oder 1
    string restAsString = rest.ToString();
    result = restAsString + result;
    number /= 2;
}
Console.WriteLine(result);