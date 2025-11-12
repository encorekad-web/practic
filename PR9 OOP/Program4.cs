using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z4
{
    public class Circle
    {
        private double radius;

        public double Radius
        {
            get { return radius; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Радиус должен быть больше 0!");
                    radius = 1; 
                }
                else
                {
                    radius = value;
                }
            }
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public void GetArea()
        {
            double area = Math.PI * radius * radius;
            Console.WriteLine($"Площадь круга: {area}.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(5);
            circle1.GetArea();

            Circle circle2 = new Circle(-2);
            circle2.GetArea();

            Console.ReadKey();
        }
    }
}