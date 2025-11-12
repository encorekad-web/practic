using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    public class Director : Employee
    {
        public string Department { get; set; }

        public Director(string name, decimal salary, DateTime hireDate, string dept)
            : base(name, "Директор", salary, hireDate)
        {
            Department = dept;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Отдел: " + Department);
        }

        public void ApproveBudget()
        {
            Console.WriteLine(Name.Trim() + " утверждает бюджет для отдела " + Department + ".");
        }
    }
}