using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Farmer
{
    internal class Dog
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public Dog(string name, string breed)
        {
            Name = name;
            Breed = breed;
        }

        public string Info
        {
            get
            {
                return $"{this.Name}: {this.Breed}";
            }
        }
    }
}
