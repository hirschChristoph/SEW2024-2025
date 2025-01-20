using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Farmer
{
    internal class Farmer
    {
        public string firstName {  get; set; }
        public string lastName { get; set; }

        public Dog? myDog { get; set; }         //? bedeutet Datenkomponente oder Property kann
                                                //irgendwann null werden
        public Cat? myCat { get; set; }

        public Farmer(string firstName, string lastName, Cat myCat)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            myDog = null;   //myDog hat keinen Wert
            myCat = myCat;
        }
    }
}
