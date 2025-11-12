using System;

class Book
{
    private string _title;
    public string Title { get => _title; set => _title = value; }

    private int _pages;
    public int Pages
    {
        get => _pages;
        set
        {
            if (value >= 1 && value <= 5000)
                _pages = value;
            else
                Console.WriteLine("Страниц должно быть от 1 до 5000!");
        }
    }
    public Book(string title, int pages)
    {
        Title = title;
        Pages = pages;
    }
    public Book(string title) : this(title, 100) { }
    public Book() : this("Без названия", 1) { }
    public void Read()
    {
        Console.WriteLine($"Читаю книгу \"{Title}\", страниц: {Pages}.");
    }
}