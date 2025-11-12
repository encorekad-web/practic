using System;

public class Book
{
    private string _title;
    public string Title
    {
        get => _title;
        set
        {
            if (string.IsNullOrEmpty(value))
                Console.WriteLine("Название не может быть пустым!");
            else
                _title = value;
        }
    }
    public int Pages { get; init; } = 1;
    public bool IsLong => Pages > 300;
    public Book(string title)
    {
        Title = title; 
    }
    public void Info()
    {
        Console.WriteLine($"Книга: {Title}, страниц: {Pages}, длинная: {(IsLong ? "да" : "нет")}");
    }
}