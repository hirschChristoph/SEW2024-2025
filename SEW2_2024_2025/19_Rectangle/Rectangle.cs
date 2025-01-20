using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Rectangle
{
    internal class Rectangle
    {
        private double a;
        private double b;

        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
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
            //area equals a times b
            //double newArea = this.Area() * factor;
            //a?, ab?
            //double ratio = a / b;

            //A = a * b 
            //A * factor = factor * a * b
            //a = A * factor / (factor * b)



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
