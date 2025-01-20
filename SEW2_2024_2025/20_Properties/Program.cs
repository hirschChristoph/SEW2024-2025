using _19_Rectangle;
using _20_Properties;

Rectangle hausAcker = new Rectangle(100.5, 51.2);
Console.WriteLine($"Länge: {hausAcker.GetA()}");

hausAcker.SetA(101.5);
Console.WriteLine($"Länge: {hausAcker.GetA()}");

//Verwendung von Properties
hausAcker.A = 100.5;                        //Verwendung des Setter
Console.WriteLine($"Länge: {hausAcker.A}"); //Verwendung des Getter




//neue Klasse: Cow
//Datenkomponenten: name, age, weight
//für jede Datenkomponente einen Getter und Setter
//mind. 2 Objekte von der Klasse Cow instanzieren
//von einer Kuh das Gewicht ändern
//von der anderen das Alter ändern
//Ausgabe der neuen Werte (Gewicht, Alter) auf die Konsole


Cow mino = new Cow("Mino", 5, 270.33);

Cow emma = new Cow("Emma", 11, 470.56);

emma.Weight = 490.56;       //setter

mino.Age = mino.Age + 1;

Console.WriteLine($"Gewicht von Emma: {emma.Weight}");
Console.WriteLine($"Alter von Mino: {mino.Age}");
emma.Breed = "Holstein";



