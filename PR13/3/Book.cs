using ConsoleApp31;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    public class Book : LibraryItem
    {
        public int Pages { get; set; }    
        public string ISBN { get; set; }   

        public Book(string title, string author, int year, int pages, string isbn)
            : base(title, author, year)
        {
            Pages = pages;
            ISBN = isbn;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Страниц: {Pages}");
            Console.WriteLine($"ISBN: {ISBN}");
        }
    }
}