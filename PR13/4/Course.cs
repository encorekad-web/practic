using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    public abstract class Course
    {
        public string Title { get; set; }    
        public string Description { get; set; } 
        public string Author { get; set; }    
        public decimal Price { get; set; }    

        public Course(string title, string desc, string author, decimal price)
        {
            Title = title;
            Description = desc;
            Author = author;
            Price = price;
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Курс: {Title}");
            Console.WriteLine($"Автор: {Author}");
            Console.WriteLine($"Описание: {Description}");
            Console.WriteLine($"Цена: {Price} руб.");
        }
        public abstract void StartCourse();
    }
}