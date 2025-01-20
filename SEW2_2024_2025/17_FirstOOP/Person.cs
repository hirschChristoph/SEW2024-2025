using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_FirstOOP
{
    internal class Person
    {
        //Vorlage/Schablone bzw. Klasse
        //Datenkomponenten   --> alle private, sonst Punkteabzug und Datendiebstahl
        //Datenkomponeneten werden kleingeschrieben
        private string vorname;
        private string nachname;
        private string nickname;
        private double weightInKg;
        private double sizeInM;
        private double BMI;

        //Methoden
        //großer Anfangsbuchstabe

        //spezielle Methode - Konstruktor
        //Konstruktor erzeugt ein Objekt
        //heißt wie die Klasse

        public Person(string vorname, string nachname, string nick, double weightInKg, double sizeInM, double BMI)
        {
            //Initialisierung der Datenkomponenten
            this.vorname = vorname;     //this zeigt auf "mein" Objekt
            this.nachname = nachname;
            this.nickname = nick;
            this.weightInKg = weightInKg;
            this.sizeInM = sizeInM;
            BMI = weightInKg / (sizeInM * sizeInM);
        }

        public string GetInitials()
        {
            //Rückgabetyp string ->
            return $"{vorname[0]}.{nachname[0]}";
        }
        public string GetBMI()
        {
            return $"{BMI}";
        }

    }
}
