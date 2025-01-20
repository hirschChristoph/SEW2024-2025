// See https://aka.ms/new-console-template for more information
Console.WriteLine("Datatypes!");

int i = 5;
double pi = 3.1415926;
char c = 'a';
float f = 1.67F;
bool b = true;
short s = 7;
byte by = 1;
string text = "Heute regnet es! ";
int[] intArray = { 1, 2, 3, 4 };

Console.WriteLine(i);
Console.WriteLine(f);
Console.WriteLine(pi);
Console.WriteLine(b);
Console.WriteLine("Die Zahl lautet " + s);   //s wird in einenen String umgewandelt,
                                             //+ Operator hängt zwei Strings zusammen
Console.WriteLine("Die erste Zahl lautet: " + s + " und die zweite lautet: " + by);
Console.WriteLine(i + s);   

Console.Write(text);
Console.WriteLine(text);

Console.Write("\nBitte einen Text eingeben: ");
string input = Console.ReadLine();          //alle eingaben sind ein String!
Console.WriteLine("Du hast eingegeben: " + input);
Console.Write("Bitte eine Zahl eingeben: ");
string inputNumber = Console.ReadLine();
int number = int.Parse(inputNumber);        //wandelt einen String in int um


