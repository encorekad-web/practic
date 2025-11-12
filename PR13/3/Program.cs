using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book boo = new Book("Мастер и Маргарита", "Булгаков", 1967, 450, "978-5-389-07466-2");
            Magazine m = new Magazine("Рязанские ведомости", "Редакция", 1997, 4, "ежемесячно");
            DVD dv = new DVD("Хоббит. Трилогия", "П. Джексон", 2014, 169, "PG-13");
            Audiobook a = new Audiobook("Преступление и наказание", "Ф. Достоевский", 2020, 720, "Сергей Чонишвили");

            Console.WriteLine("Материалы библиотеки: ");
            boo.DisplayInfo(); Console.WriteLine();
            m.DisplayInfo(); Console.WriteLine();
            dv.DisplayInfo(); Console.WriteLine();
            a.DisplayInfo(); Console.WriteLine();

            Console.WriteLine("Проверка выдачи: ");
            boo.Borrow();
            boo.Borrow();
            boo.Return();
            boo.Return();

            Console.ReadLine();
        }
    }
}