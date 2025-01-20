using _17_FirstOOP;

int i = 5;  

Person christoph = new Person("Christoph", "Hirsch", "Chrisi", 55, 1.75);        /* eine Variable mit dem Namen Christoph vom Datentyp Person deklariert und ein neues Objekt der Klasse Person erzeugt 
                                                                                  und der Variable christoph zugewiesen.*/
Person laura = new Person("Laura", "Mandl", "Maundlin", 35, 1.60);
Person andreas = new Person("Andreas", "Veigl", "Vogl", 85, 1.85);

string initialsChristoph = christoph.GetInitials();
Console.WriteLine(initialsChristoph);


//ein weiteres Objekt mit "euren Daten" erstellen und Initialen aud der Konsole ausgeben.


Person moritz = new Person("Moritz", "Hintermair", "Momo", 40, 1.60);

string initialsMoritz = moritz.GetInitials();
Console.WriteLine(initialsMoritz);

Person john = new Person("John", "Doe", "JohnD", 80, 1.90);
Person jane = new Person("Jane", "Doe", "JaneD", 55, 1.65);
Console.WriteLine(john.GetInitials());
Console.WriteLine(jane.GetInitials());

//eine weitere methode GetBMI


Console.WriteLine(andreas.GetBMI());





