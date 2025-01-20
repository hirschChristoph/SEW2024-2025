DateTime christmas = new DateTime(2024, 12, 24, 20, 0, 0);
Console.WriteLine(christmas.ToShortDateString());
Console.WriteLine(christmas.ToLongDateString());
Console.WriteLine(christmas.ToString());

DateOnly birthday = new DateOnly(2008, 9, 16);
Console.WriteLine(birthday.ToLongDateString());

TimeOnly sleepingTime = new TimeOnly(22, 35);
Console.WriteLine(sleepingTime.ToShortTimeString());

DateTime now = DateTime.Now;
Console.WriteLine($"Jetzt: {now.ToString()}");
DateOnly dateNow = DateOnly.FromDateTime(DateTime.Now);

TimeOnly timeNow = TimeOnly.FromDateTime(DateTime.Now);

TimeSpan tillChristmas = christmas - DateTime.Now;
Console.WriteLine($"Bis Weihnachten: {tillChristmas.Days} Tage");
TimeSpan tillSleeping = sleepingTime - timeNow;
Console.WriteLine($"Bis zum Schlafen: {tillSleeping.TotalMinutes:f0} Minuten");

DateOnly today = DateOnly.FromDateTime(DateTime.Now);
DateOnly payDate = today.AddDays(30);
Console.WriteLine($"Rechnung zu bezahlen bis: {payDate.ToShortDateString()}");


Console.WriteLine("________________________________________________________________");
Console.WriteLine("________________________________________________________________");

DateTime now2 = DateTime.Now;
Console.WriteLine(now2.ToShortDateString() );
TimeOnly now3 = TimeOnly.FromDateTime(DateTime.Now);
Console.WriteLine(now3.ToString() );
Console.WriteLine("________________________________________________________________");

DateTime easter = new DateTime(2025, 4, 20);
TimeSpan tillEaster = easter - DateTime.Now;
Console.WriteLine($"Bis Ostern: {tillEaster.Days}");

DateTime birthdayAge = new DateTime(2025, 9, 16);
TimeSpan tillBirthday = birthdayAge - DateTime.Now;
Console.WriteLine($"Bis zum Geburtstag: {tillBirthday.Days}");
Console.WriteLine("________________________________________________________________");

Console.WriteLine("Bitte eine Taste drücken.");
Console.ReadLine();
DateTime start = DateTime.Now;

Console.WriteLine("Bitte eine Taste drücken.");
Console.ReadKey();
DateTime stop = DateTime.Now;

TimeSpan span = stop - start;
Console.WriteLine($"Vergangene Zeit: {span.TotalMilliseconds:f0} Millisekunden");



