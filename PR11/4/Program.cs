using System;

class Program
{
    static void Main()
    {
        var product = new Product(1000, 20);
        product.Name = "Ноутбук"; 
        product.Show(); 
        product.Discount = 10;
        product.Show();
        product.Price = -500;
        Console.ReadLine();
    }
}