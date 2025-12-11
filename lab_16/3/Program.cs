using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main()
        {
            var m1 = new Money(10, 50);
            var m2 = new Money(5, 75);

            Console.WriteLine(m1 + m2);
            Console.WriteLine(m1 == new Money(10, 50));
        }
    }
}