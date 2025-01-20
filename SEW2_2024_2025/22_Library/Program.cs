using _22_Library;

Library buchAusstellungWeihnachten2024 = new Library();
Book bookAhorner = new Book("Peter Ahorner", "Handbuch der österreichischen Schimpfwörter", 120);
Book bookBruecklmeier = new Book("Jan Brücklmeier", "Bier brauen", 512);
Book bookRhue = new Book("Morthon Rhue", "Die Welle", 136);
Book bookHesse = new Book("Christian Hesse", "Von Zahlen, Menschen und Maschinen", 224);

buchAusstellungWeihnachten2024.PrintBookList();

buchAusstellungWeihnachten2024.BorrowBook();

