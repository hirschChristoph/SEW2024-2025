using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Farmer
{
    internal class Cat
    {
        public string Name { get; set; }
        public string Color { get; set; }

        public Cat(string name, string color)
        {
            Name = name;    //setter des Properties
            Color = color;
        }
        public string GetInfo()
        {
            return $"{this.Name}: {this.Color}";
        }       //Bereich auskommentieren mit strg + k, k loslassen + c

        public string Info      //Read only Property
        {
            get
            {
                return $"{this.Name}: {this.Color}";
            }
        }
    }
}
