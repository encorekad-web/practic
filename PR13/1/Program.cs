using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee manager = new Manager("Иванов  Александр  ", 180000, new DateTime(2020, 11, 9), 10);
            Employee developer = new Developer("Кузнецов Денис   ", 150000, new DateTime(2022, 11, 9), "C#");
            Employee director = new Director("Петров Михаил ", 140000, new DateTime(2015, 11, 9), "IT");

            manager.ShowInfo();
            ((Manager)manager).HoldMeeting();

            developer.ShowInfo();
            ((Developer)developer).WriteCode();

            director.ShowInfo();
            ((Director)director).ApproveBudget();
        }
    }
}