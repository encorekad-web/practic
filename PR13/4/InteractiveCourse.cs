using ConsoleApp32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    public class InteractiveCourse : Course
    {
        public int Exercises { get; set; }     
        public string CheckSystem { get; set; } 
        public InteractiveCourse(string title, string desc, string author, decimal price, int exercises, string check)
            : base(title, desc, author, price)
        {
            Exercises = exercises;
            CheckSystem = check;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Упражнений: {Exercises}, Проверка: {CheckSystem}");
        }

        public override void StartCourse()
        {
            Console.WriteLine($"Начало интерактивного курса '{Title}'");
        }
    }
}