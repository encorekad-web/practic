using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        interface Iworking
        {
            void Work();
        }
        interface Izaryadka
        {
            void zarr();
        }
        class Robot : Iworking, Izaryadka
        {
            public string Name { get; set; }
            public int Energy { get; set; }
            public Robot(string name, int Energy)
            {
                Name = name;
                Energy = 100;
            }
            public void Work()
            {
                if (Energy >= 20)
                {
                    Energy -= 20;
                    Console.WriteLine($"{Name} Работает. Энергия {Energy}");
                }
                else
                {
                    Console.WriteLine($"{Name} не работает. Энергия {Energy}");

                }
            }

            public void zarr()
            {
                Energy = Math.Min(Energy + 50, 100);
                Console.WriteLine($"{Name} заряжается. Энергия {Energy}");
            }
        }
        static void Main(string[] args)
        {
            Robot zz  = new Robot("Robot", 100);
            zz.Work();
            zz.Work();
            zz.zarr();
            zz.Work();


            Console.ReadLine();
        }
    }
}







