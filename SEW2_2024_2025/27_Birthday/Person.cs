using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _27_Birthday
{
    internal class Person
    {
        private string fname;
        private string lname;
        private DateTime age;
        public int ageYear;

        public Person(string fname, string lname, DateTime age)
        {
            this.fname = fname;
            this.lname = lname;
            this.age = age;
        }
            
        public string Age
        {
            get{
                ageYear = age.Year;
                return $"Geburtsjahr: {this.ageYear}";
            }
        }
        //public string Info      //Read only Property
        //{
        //    get
        //    {
        //        return $"Alter: {this.age}";
        //    }
        //}
    }
}
