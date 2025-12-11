using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main()
        {
            var s = new Score();

            s["Математика"] = 5;
            s["Русский"] = 4;
            s["Информатика"] = 5;
            Console.WriteLine(s["Математика"]);
            Console.WriteLine(s);
        }
    }
}