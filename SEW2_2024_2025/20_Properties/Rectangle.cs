using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Rectangle
{
    
    internal class Rectangle
    {
        private double a;       //Datenkomponenten private
        private double b;

        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }   

        public double A
        {
            get
            {
                return this.a;
            }
            set
            {
                if(value < 0)
                {
                    return;
                }
                this.a = value;
            }
        }



        public double GetA()                //getter
        {
            return this.a;
        }

        public void SetA(double newValue)   //setter
        {
            if(newValue < 0)
            {
                return;
            }
            this.a = newValue;
        }

        public double Area()
        { 
            return a * b;
        }

        public double Circumference()
        {
            return 2 * (a + b);
        }

        public void ResizeArea(double factor)
        {
            this.a = (this.Area() * factor / Math.Sqrt(factor)) / b;
            this.b = (this.Area() * factor / Math.Sqrt(factor)) / a;
        }

        public void ResizeSideLenght(double factor)
        {
            this.a = this.a * factor;
            this.b = this.b * factor;   
        }
    }
}
