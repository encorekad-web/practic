using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    public class Developer : Employee
    {
        public string ProgrammingLanguage { get; set; }

        public Developer(string name, decimal salary, DateTime hireDate, string lang)
            : base(name, "Разработчик", salary, hireDate)
        {
            ProgrammingLanguage = lang;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Язык программирования: " + ProgrammingLanguage);
        }

        public void WriteCode()
        {
            Console.WriteLine(Name.Trim() + " пишет код на языке " + ProgrammingLanguage + ".");
        }
    }
}