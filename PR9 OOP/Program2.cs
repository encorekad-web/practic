using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2
{
    public class Phone
    {
        private string brand;
        private int batteryLevel;

        public string Brand { get { return brand; } set { brand = value; } }
        public int BatteryLevel
        {
            get { return batteryLevel; }
            set
            {
                if (value < 0 || value > 100)
                {
                    Console.WriteLine("Заряд должен быть от 0 до 100!");
                    batteryLevel = 0;
                }
                else
                {
                    batteryLevel = value;
                }
            }
        }
        public Phone(string brand, int batteryLevel)
        {
            Brand = brand;
            BatteryLevel = batteryLevel;
        }
        public void UsePhone()
        {
            Console.WriteLine($"Телефон {Brand}, заряд: {batteryLevel}%");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Phone phone1 = new Phone("Samsung", 80);
            phone1.UsePhone();

            Console.WriteLine();

            Phone phone2 = new Phone("Samsung", 70);
            phone2.UsePhone();

            Console.WriteLine();

            Phone phone3 = new Phone("Samsung", -10);
            phone2.UsePhone();
        }
    }
}
