using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Animals
{
    internal class Cat
    {
        private string name;
        private string color;

        public Cat(string name, string color)
        { this.name = name;
            this.color = color;
        }
        public string GetInfoC()
        {
            return $"{name}, {color}";
        }
    }
}
