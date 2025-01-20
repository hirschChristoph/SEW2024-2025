using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Animals
{

    internal class Dog
    {
        private string name;
        private string race;

        public Dog(string name, string race)
        {
            this.name = name;
            this.race = race;
        }
        public string GetInfoD()
        {
            return $"{name}, {race}";
        }       
    }
}  
    
    