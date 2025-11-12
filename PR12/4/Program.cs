using System;

class Program
{
    static void Main()
    {
        var book = new book("978-5-0064-0271-3");
        book.Title = "Синдбад-Мореход";
        book.Author = "Алексей Козлов";
        book.ShowInfo();
        Console.ReadLine();
    }
}