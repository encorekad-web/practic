using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    public abstract class LibraryItem
    {
        public string Title { get; set; }     
        public string Author { get; set; }    
        public int Year { get; set; }          
        public bool IsAvailable { get; set; } 

        public LibraryItem(string title, string author, int year, bool isAvailable = true)
        {
            Title = title;
            Author = author;
            Year = year;
            IsAvailable = isAvailable;
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Название: {Title}");
            Console.WriteLine($"Автор: {Author}");
            Console.WriteLine($"Год: {Year}");
            Console.WriteLine($"Доступна: {(IsAvailable ? "Да" : "Нет")}");
        }
        public void Borrow()
        {
            if (IsAvailable)
            {
                IsAvailable = false;
                Console.WriteLine($"'{Title}' выдан.");
            }
            else
            {
                Console.WriteLine($"'{Title}' уже выдан.");
            }
        }
        public void Return()
        {
            if (!IsAvailable)
            {
                IsAvailable = true;
                Console.WriteLine($"'{Title}' возвращен в библиотеку.");
            }
            else
            {
                Console.WriteLine($"'{Title}' уже в библиотеке.");
            }
        }
    }
}