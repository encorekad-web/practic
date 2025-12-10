using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
interface IPricedItem
{
    decimal Price { get; }
}
interface iItem
{
    int Mmonths { get; }
}
class Phone : IPricedItem, iItem
{
    public decimal Price { get; }
    public int Mmonths { get; }

    public Phone(decimal price, int months)
    {
        Price = price;
        Mmonths = months;
    }
}
class Laptop : IPricedItem
{
    public decimal Price { get; }
    public Laptop(decimal price)
    {
        Price = price;
    }
}
class Program
{
    static void Main()
    {
        var items = new List<object>()
        {
            new Phone(price: 30000m, months: 18),
            new Laptop(price: 50000m),
            new Phone(price: 25000m, months: 12)
        };

        decimal totalSum = 0; 
        foreach (var item in items)
        {
            if (item is IPricedItem pricedItem)
            {
                totalSum += pricedItem.Price;
                if (item is iItem wItem)
                {
                    Console.WriteLine($"Цена: {pricedItem.Price}, Срок гарантии: {wItem.Mmonths} месяца(-ев)");
                }
                else
                {
                    Console.WriteLine($"Цена: {pricedItem.Price}, Гарантия отсутствует");
                }
            }
        }
        Console.WriteLine("\nИтого: " + totalSum.ToString());
        Console.ReadLine();
    }
}