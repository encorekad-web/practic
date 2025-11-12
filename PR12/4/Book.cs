using System;

public class book
{
    private readonly string isbn;
    public string Title { get; set; }
    public string Author { get; set; }
    public book(string isbn)
    {
        this.isbn = isbn;
    }
    public void ShowInfo()
    {
        Console.WriteLine($"ISBN: {isbn}, Название: {Title}, Автор: {Author}");
    }
}