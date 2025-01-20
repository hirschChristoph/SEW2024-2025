using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Properties
{
    internal class Cow
    {
        private string name;
        private int age;
        private double weight;
        

        public Cow(string name, int age, double weight)
        {
            this.name = name;
            this.age = age;
            this.weight = weight;
            
        }
        public string Breed { get; set; }    //keine Validierungslogik
        public string Name
        {
            get
            {
                return name;
            }
            set 
            { name = value;
           }
                  
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }

    }
}

