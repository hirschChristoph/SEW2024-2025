
Console.Write("Bitte einen Text eingeben: ");
    
string text = Console.ReadLine();

//for(int i = 0; i < text.Length; i++)
{
 //   char c = text[i];
 //   Console.Write(c + " ");
}

foreach(char c in text)
{
    Console.Write(c + " ");
}