using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    public class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }

        public Employee(string name, string position, decimal salary, DateTime hireDate)
        {
            Name = name;
            Position = position;
            Salary = salary;
            HireDate = hireDate;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine("\nИмя: " + Name.Trim());
            Console.WriteLine("Должность: " + Position);
            Console.WriteLine("Зарплата: " + Salary.ToString("C"));
            Console.WriteLine("Дата приема: " + HireDate.ToShortDateString());
        }
    }
}
