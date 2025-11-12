using System;
public class Product
{
    private double price;
    private double discount;
    public double Price
    {
        get => price;
        set
        {
            if (value >= 0)
                price = value;
            else
                Console.WriteLine("Цена не может быть отрицательной!");
        }
    }
    public double Discount
    {
        get => discount;
        set
        {
            if (value >= 0 && value <= 100)
                discount = value;
            else
                Console.WriteLine("Скидка должна быть от 0 до 100%!");
        }
    }
    public string Name { get; init; } = "Без названия";
    public double FinalPrice => price * (1 - discount / 100);
    public Product(double price, double discount)
    {
        Price = price;
        Discount = discount;
    }
    public void Show()
    {
        Console.WriteLine($"{Name}: {FinalPrice:F2} (скидка {Discount}%)");
    }
}