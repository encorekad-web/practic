using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1
{ 
    public class Person
    {
        private string name;
        private int age;

        public string Name { get { return name; } set { name = value; } }
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0 || value > 120)
                {
                    Console.WriteLine("Возраст должен быть от 0 до 120!");
                    age = 0;
                }
                else
                {
                    age = value;
                }
            }
        }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void SayHello()
        {
            Console.WriteLine($"Привет, я {Name}, мне {Age} лет!");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person persone1 = new Person("Маша", 25);
            persone1.SayHello();

            Console.WriteLine();

            Person persone2 = new Person("Маша", 150);
            persone2.SayHello();


            Console.WriteLine();

            Person persone3 = new Person("Маша", -5);
            persone3.SayHello();

        }
    }
}
