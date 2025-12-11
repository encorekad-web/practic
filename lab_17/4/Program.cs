using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("Анна");
            names.Add("Петр"); 
            names.Add("Анна");
            names.Add("Ольга");
            names.Add("Петр");
            names.Add("Иван");
            Console.WriteLine("Исходный список:");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            List<string> uniqueNames = new List<string>();
            foreach (string name in names)
            {
                if (!uniqueNames.Contains(name))
                {
                    uniqueNames.Add(name);
                }
            }
            Console.WriteLine("\nСписок без дубликатов:");
            foreach (string name in uniqueNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}