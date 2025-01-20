DateTime old2022 = new DateTime(2022, 11, 30, 11, 4, 3, 593, 3);
Console.WriteLine(old2022.ToShortDateString());
Console.WriteLine(old2022.ToShortTimeString());
Console.WriteLine(old2022.ToLongDateString());
Console.WriteLine(old2022.ToLongTimeString());
Console.WriteLine($"Jahr: {old2022.Year}");
Console.WriteLine($"Monat: {old2022.Month}");
Console.WriteLine($"Tag: {old2022.Day}");
Console.WriteLine($"Stunde: {old2022.Hour}");
Console.WriteLine($"Minute: {old2022.Minute}");
Console.WriteLine($"Sekunde: {old2022.Second}");
Console.WriteLine($"Millisekunde: {old2022.Millisecond}");
Console.WriteLine($"Mikrosekunde: {old2022.Microsecond}");
Console.WriteLine($"Wochentag: {old2022.DayOfWeek}");

DateTime MyBirthday = new DateTime(2008, 9, 16);
Console.WriteLine($"Mein Geburtstag: {MyBirthday.ToLongDateString()}");
Console.WriteLine($"Wochentag meiner Geburt: {MyBirthday.DayOfWeek}");
//Console.WriteLine($"Mein Alter in Tagen: {MyBirthday.Day} "); Differnz nötig
//Console.WriteLine($"Mein Alter in Sekunden: {MyBirthday.Second}");
