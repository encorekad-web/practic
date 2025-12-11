using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> stock = new Dictionary<string, int>();
            stock["Молоко"] = 79;
            stock["Хлеб"] = 50;
            stock["Яйца"] = 20;
            stock["Сахар"] = 10;
            stock["Сок"] = 120;
            stock["Вода"] = 59;
            List<string> sold = new List<string>();
            Console.WriteLine("Продаем товары:");
            if (stock["Молоко"] > 0)
            {
                stock["Молоко"]--;
                sold.Add("Молоко");
                Console.WriteLine("Молоко продан");
            }
            if (stock["Молоко"] > 0)
            {
                stock["Молоко"]--;
                sold.Add("Молоко");
                Console.WriteLine("Молоко продан");
            }
            if (stock["Хлеб"] > 0)
            {
                stock["Хлеб"]--;
                sold.Add("Хлеб");
                Console.WriteLine("Хлеб продан");
            }
            if (stock["Яйца"] > 0)
            {
                stock["Яйца"]--;
                sold.Add("Яйца");
                Console.WriteLine("Яйца проданы");
            }
            Console.WriteLine("Что осталось:");
            Console.WriteLine($"Хлеб: {stock["Хлеб"]}\n");
            Console.WriteLine($"Молоко: {stock["Молоко"]}");
            Console.WriteLine($"Яйца: {stock["Яйца"]}");
            Console.WriteLine($"Сахар: {stock["Сахар"]}");
            Console.WriteLine($"Масло: {stock["Масло"]}");
            Console.WriteLine($"Соль: {stock["Соль"]}");
            Console.WriteLine("Сколько продали:");
            int milkC = 0;
            int breadC = 0;
            int eggsC = 0;
            foreach (string product in sold)
            {
                if (product == "Молоко") milkC++;
                if (product == "Хлеб") breadC++;
                if (product == "Яйца") eggsC++;
            }

            if (milkC > 0)
                Console.WriteLine($"Молоко - {milkC} раза");
            if (breadC > 0)
                Console.WriteLine($"Хлеб - {breadC} раз");
            if (eggsC > 0)
                Console.WriteLine($"Яйца - {eggsC} раз");
        }
    }
}