using System;

class Program
{
    static void Main()
    {
        var book1 = new Book("Война и мир");
        book1.Pages = 1200;
        book1.Info();
        var book2 = new Book("");
        book2.Pages = 1;
        book2.Info();
        Console.ReadLine();
    }
}