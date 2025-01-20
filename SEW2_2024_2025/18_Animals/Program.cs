//Erstelle ein Klasse Dog mit den Datenkomponenten Name und Rasse. Erstelle zu dieser Klasse eine Methode GetInfo, welche den Namen und die Rasse als string zurückliefert

//Erstelle ein Klasse Cat mit den Datenkomponenten Name und Rasse. Erstelle zu dieser Klasse eine Methode GetInfo, welche den Namen und die Rasse als string zurückliefert

//Erstelle zumindest 2 Objekte jeder Klasse (insgesamt mind.4 Objekte), inkl. Aufruf der Methode GetInfo und Ausgabe auf die Konsole.

using _18_Animals;


Dog schaefer = new Dog("Hans", "Schäferhund");

Dog dackel = new Dog("Heinz", "Dackel");

Console.WriteLine(schaefer.GetInfoD());
Console.WriteLine(dackel.GetInfoD());


Cat garfield = new Cat("Garfield", "orange-weiß getigert");

Cat sammy = new Cat("Sammy", "braun-schwarz getigert");

Console.WriteLine(garfield.GetInfoC());
Console.WriteLine(sammy.GetInfoC());

