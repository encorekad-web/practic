using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z5
{
    public class Pet
    {
        private string name;
        private int energy;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Energy
        {
            get { return energy; }
            set
            {
                if (value < 0 || value > 100)
                {
                    Console.WriteLine("Энергия должна быть от 0 до 100!");
                    energy = 50;
                }
                else
                {
                    energy = value;
                }
            }
        }

        public Pet(string name, int energy)
        {
            Name = name;
            Energy = energy;
        }

        public void Play()
        {
            energy = Math.Max(0, energy - 20);
            Console.WriteLine($"{Name} играет, энергия: {energy}.");
        }

        public void Rest()
        {
            energy = Math.Min(100, energy + 30);
            Console.WriteLine($"{Name} отдыхает, энергия: {energy}.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           
            Pet pet = new Pet("Рекс", 80);
            pet.Play();  
            pet.Rest();  

            Console.WriteLine();

            Pet pet2 = new Pet("Рекс", 150);
            pet2.Play();

            Console.ReadKey();
        }
    }
}